using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface IParceiroRepository
    {
        public void Cadastrar(Parceiro parceiro);
        public void Deletar(int id);
        public void Atualizar(int id, Parceiro parceiro);
        public Parceiro BuscarPorId(int id);
        public List<Parceiro> Listar();
    }
}
