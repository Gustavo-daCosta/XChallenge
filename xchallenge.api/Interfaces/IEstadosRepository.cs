using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface IEstadosRepository
    {
        public Estado BuscarPorId(int id);
        public List<Estado> Listar();
    }
}
