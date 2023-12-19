using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface ISkillRepository
    {
        public DataNacional BuscarPorId(int id);
        public List<DataNacional> Listar();
    }
}
