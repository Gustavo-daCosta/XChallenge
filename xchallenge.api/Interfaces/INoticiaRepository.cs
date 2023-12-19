using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface INoticiaRepository
    {
        public void Cadastrar(Noticia noticia);
        public void Deletar(int id);
        public void Atualizar(int id, Noticia noticia);
        public Noticia BuscarPorId(int id);
        public List<Noticia> Listar();
    }
}
