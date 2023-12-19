using xchallenge.api.Contexts;
using xchallenge.api.Domains;
using xchallenge.api.Interfaces;

namespace xchallenge.api.Repositories
{
    public class ParceiroRepository : IParceiroRepository
    {
        private readonly XChallengeContext _context;

        public ParceiroRepository()
        {
            _context = new XChallengeContext();
        }

        public void Atualizar(int id, Parceiro parceiro)
        {
            try
            {
                Parceiro parceiroBuscado = _context.Parceiros.Find(id)!;

                if (parceiroBuscado != null)
                {
                    parceiroBuscado.Logo = parceiro.Logo;
                    parceiroBuscado.Nome = parceiro.Nome;
                    parceiroBuscado.Descricao = parceiro.Descricao;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Parceiro BuscarPorId(int id)
        {
            try
            {
                Parceiro parceiroBuscado = _context.Parceiros.FirstOrDefault(a => a.IdParceiro == id)!;
                return parceiroBuscado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Parceiro parceiro)
        {
            try
            {
                _context.Parceiros.Add(parceiro);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(int id)
        {
            try
            {
                Parceiro parceiroBuscado = BuscarPorId(id);

                if (parceiroBuscado != null)
                {
                    _context.Parceiros.Remove(parceiroBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Parceiro> Listar()
        {
            try
            {
                return _context.Parceiros.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
