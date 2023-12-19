using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface ICompetidorRepository
    {
        public void Cadastrar(Competidor competidor);
        public void Deletar(int id);
        public void Atualizar(int id, Competidor competidor);
        public Competidor BuscarPorId(int id);
        public List<Competidor> Listar();
    }
}
