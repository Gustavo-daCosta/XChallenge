using xchallenge.api.Domains;

namespace xchallenge.api.Interfaces
{
    public interface INotaCompetidorRepository
    {
        public void Cadastrar(NotaCompetidor notaCompetidor);
        public void Deletar(int id);
        public void Atualizar(int id, NotaCompetidor notaCompetidor);
        public NotaCompetidor BuscarPorId(int id);
        public List<NotaCompetidor> Listar();
    }
}
