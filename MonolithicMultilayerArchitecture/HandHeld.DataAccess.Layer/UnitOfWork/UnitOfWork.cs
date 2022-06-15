
namespace HandHeld.DataAccess.Layer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HandHeldDbContext _context;
        public UnitOfWork(HandHeldDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
