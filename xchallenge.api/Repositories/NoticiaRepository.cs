using xchallenge.api.Contexts;
using xchallenge.api.Domains;
using xchallenge.api.Interfaces;

namespace xchallenge.api.Repositories
{
    public class NoticiaRepository : INoticiaRepository
    {
        private readonly XChallengeContext _context;

        public NoticiaRepository()
        {
            _context = new XChallengeContext();
        }

        public void Atualizar(int id, Noticia noticia)
        {
            try
            {
                Noticia noticiaBuscada = _context.Noticia.Find(id)!;

                if (noticiaBuscada != null)
                {
                    noticiaBuscada.Data = noticia.Data;
                    noticiaBuscada.Titulo = noticia.Titulo;
                    noticiaBuscada.noticia = noticia.noticia;
                    noticiaBuscada.Status = noticia.Status;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Noticia BuscarPorId(int id)
        {
            try
            {
                Noticia noticiaBuscada = _context.Noticia.FirstOrDefault(a => a.Id == id)!;
                return noticiaBuscada;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Noticia noticia)
        {
            try
            {
                _context.Noticia.Add(noticia);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(int id)
        {
            try
            {
                Noticia noticiaBuscada = BuscarPorId(id);

                if (noticiaBuscada != null)
                {
                    _context.Noticia.Remove(noticiaBuscada);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Noticia> Listar()
        {
            try
            {
                return _context.Noticia.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
