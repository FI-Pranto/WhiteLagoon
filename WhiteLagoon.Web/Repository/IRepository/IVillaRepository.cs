using System.Linq.Expressions;
using WhiteLagoon.Web.Models;

namespace WhiteLagoon.Web.Repository.IRepository
{
    public interface IVillaRepository
    {
        Villa Get(int? id);

        IEnumerable<Villa> GetAll(string? includeProp);

        void Add(Villa villa);
        void Update(Villa villa);

        void Delete(Villa villa);

        void RemoveRange(List<Villa> villaList);

    }
}
