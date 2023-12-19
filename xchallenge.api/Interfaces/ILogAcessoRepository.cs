using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface ILogAcessoRepository
    {
        public void Cadastrar(LogAcesso logAcesso);
        public void Deletar(int id);
        public LogAcesso BuscarPorId(int id);
        public List<LogAcesso> BuscarAcessosUsuario(int idUsuario);
        public List<Noticia> Listar();
    }
}
