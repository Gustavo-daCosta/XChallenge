using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface IAcessoRepository
    {
        public void Cadastrar(Acesso acesso);
        public void Atualizar(int id, Acesso acesso);
        public Acesso BuscarPorId(int id);
        public Acesso BuscarPorEmailSenha(string email, string senha);
    }
}
