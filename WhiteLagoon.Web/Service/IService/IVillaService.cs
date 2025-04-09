using WhiteLagoon.Web.Models;

namespace WhiteLagoon.Web.Service.IService
{
    public interface IVillaService
    {
        Villa GetVillaById(int? id);

        IEnumerable<Villa> GetAllVilla(string? includeProp=null);

        void UpdateVilla(Villa villa);

        void DeleteVilla(Villa villa);

        void AddVilla(Villa villa);

        
    }
}
