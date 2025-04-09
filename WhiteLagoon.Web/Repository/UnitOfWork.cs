using WhiteLagoon.Web.Data;
using WhiteLagoon.Web.Repository.IRepository;

namespace WhiteLagoon.Web.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db) { 
        _db = db;
        
        }
        public void Commit()
        {
            _db.SaveChanges();
        }
    }
}
