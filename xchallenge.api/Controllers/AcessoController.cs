using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xchallenge.api.Domains;
using xchallenge.api.Interfaces;
using xchallenge.api.Repositories;

namespace xchallenge.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AcessoController : ControllerBase
    {
        private IAcessoRepository _acessoRepository { get; set; }

        public AcessoController()
        {
            _acessoRepository = new AcessoRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_acessoRepository.BuscarPorId(id));
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("BuscarPorEmailSenha")]
        public IActionResult GetByEmailPassword(string email, string senha)
        {
            try
            {
                return Ok(_acessoRepository.BuscarPorEmailSenha(email, senha));
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Acesso acesso)
        {
            try
            {
                _acessoRepository.Cadastrar(acesso);

                return StatusCode(201);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(int id, Acesso acesso)
        {
            try
            {
                _acessoRepository.Atualizar(id, acesso);

                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
