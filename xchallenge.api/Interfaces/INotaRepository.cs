using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface INotaRepository
    {
        public void Cadastrar(Nota nota);
        public void Deletar(int id);
        public void Atualizar(int id, Nota nota);
        public Nota BuscarPorId(int id);
        public List<Nota> Listar();
    }
}
