using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Web.Data;
using WhiteLagoon.Web.Models;
using WhiteLagoon.Web.Repository.IRepository;

namespace WhiteLagoon.Web.Repository
{
    public class VillaRepository : IVillaRepository
    {

        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) { 

            _db = db;
        }
        public void Add(Villa villa)
        {
            _db.Villas.Add(villa);
        }

        public void Delete(Villa villa)
        {
            _db.Villas.Remove(villa);
        }

        public Villa Get(int? id)
        {
            var villa = _db.Villas.FirstOrDefault(u => u.Id == id);

            return villa;
        }
        

        public IEnumerable<Villa> GetAll(string? includeProp)
        {
            IQueryable<Villa> query = _db.Villas;

            if(includeProp != null)
            {
                foreach(var item in includeProp.Split(","))
                {
                    query=query.Include(item);
                }
            }

            return query.ToList();
        }

        public void RemoveRange(List<Villa> villaList)
        {
            _db.Villas.RemoveRange(villaList);
        }

        public void Update(Villa villa)
        {
            _db.Villas.Update(villa);
        }
    }
}
