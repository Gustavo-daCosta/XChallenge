using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface IDataNacionalRepository
    {
        public void Cadastrar(DataNacional dataNacional);
        public void Deletar(int id);
        public void Atualizar(int id, DataNacional dataNacional);
        public DataNacional BuscarPorId(int id);
        public List<DataNacional> Listar();
    }
}
