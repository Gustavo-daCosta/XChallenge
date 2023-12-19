using xchallenge.api.Contexts;

namespace xchallenge.api.Repositories
{
    public class NotaRepository
    {
        private readonly XChallengeContext _context;

        public NotaRepository()
        {
            _context = new XChallengeContext();
        }
    }
}
