using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface IModalidadeRepository
    {
        public DataNacional BuscarPorId(int id);
        public List<DataNacional> Listar();
    }
}
