using XGame.Infra.Persistence;
using XGame.Infra2.Transactions;

namespace XGame.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly XGameContext _context;

        public UnitOfWork(XGameContext context)
        {
            _context = context;

        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
