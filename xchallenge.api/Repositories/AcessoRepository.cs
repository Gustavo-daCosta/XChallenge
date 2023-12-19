using xchallenge.api.Contexts;
using xchallenge.api.Domains;
using xchallenge.api.Interfaces;

namespace xchallenge.api.Repositories
{
    public class AcessoRepository : IAcessoRepository
    {
        private readonly XChallengeContext _context;

        public AcessoRepository()
        {
            _context = new XChallengeContext();
        }

        public void Atualizar(int id, Acesso acesso)
        {
            try
            {
                Acesso acessoBuscado = _context.Acessos.Find(id)!;

                if (acessoBuscado != null)
                {
                    acessoBuscado.Nome = acesso.Nome;
                    acessoBuscado.Email = acesso.Email;
                    acessoBuscado.SenhaAcesso = acesso.SenhaAcesso;
                }

                _context.Acessos.Update(acessoBuscado!);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Acesso BuscarPorEmailSenha(string email, string senha)
        {
            try
            {
                Acesso acessoBuscado = _context.Acessos.FirstOrDefault(a => a.Email == email && a.SenhaAcesso == senha)!;
                return acessoBuscado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Acesso BuscarPorId(int id)
        {
            try
            {
                Acesso acessoBuscado = _context.Acessos.FirstOrDefault(a => a.IdAcesso == id)!;
                return acessoBuscado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Acesso acesso)
        {
            try
            {
                _context.Acessos.Add(acesso);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
