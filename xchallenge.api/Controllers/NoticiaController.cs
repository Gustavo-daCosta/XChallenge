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
    public class NoticiaController : ControllerBase
    {
        private INoticiaRepository _noticiaRepository { get; set; }

        public NoticiaController()
        {
            _noticiaRepository = new NoticiaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_noticiaRepository.Listar());
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_noticiaRepository.BuscarPorId(id));
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Noticia noticia)
        {
            try
            {
                _noticiaRepository.Cadastrar(noticia);
                return StatusCode(201);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(int id, Noticia noticia)
        {
            try
            {
                _noticiaRepository.Atualizar(id, noticia);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _noticiaRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}
