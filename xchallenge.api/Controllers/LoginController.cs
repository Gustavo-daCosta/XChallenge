using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using xchallenge.api.Domains;
using xchallenge.api.Interfaces;
using xchallenge.api.Repositories;
using xchallenge.api.ViewModels;

namespace xchallenge.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IAcessoRepository _acessoRepository;

        public LoginController()
        {
            _acessoRepository = new AcessoRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                Acesso acessoBuscado = _acessoRepository.BuscarPorEmailSenha(usuario.Email!, usuario.Senha!);

                if (acessoBuscado == null)
                {
                    return StatusCode(401, "Email ou senha inválidos!");
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, acessoBuscado.Email!),
                    new Claim(JwtRegisteredClaimNames.Name,acessoBuscado.Nome!),
                    new Claim(JwtRegisteredClaimNames.Jti, acessoBuscado.IdAcesso.ToString()),
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("xchallenge-api-authentication-key"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //token
                var meuToken = new JwtSecurityToken(
                    issuer: "xchallenge.api",
                    audience: "xchallenge.api",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: creds
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(meuToken)
                });
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
