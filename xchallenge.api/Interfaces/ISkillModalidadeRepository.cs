using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface ISkillModalidadeRepository
    {
        public SkillModalidade BuscarPorId(int id);
        public List<SkillModalidade> Listar();
    }
}
