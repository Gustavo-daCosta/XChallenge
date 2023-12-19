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
    public class ParceiroController : ControllerBase
    {
        private IParceiroRepository _parceiroRepository { get; set; }

        public ParceiroController()
        {
            _parceiroRepository = new ParceiroRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_parceiroRepository.Listar());
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_parceiroRepository.BuscarPorId(id));
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Parceiro parceiro)
        {
            try
            {
                _parceiroRepository.Cadastrar(parceiro);

                return StatusCode(201);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Parceiro parceiro)
        {
            try
            {
                _parceiroRepository.Atualizar(id, parceiro);

                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _parceiroRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
