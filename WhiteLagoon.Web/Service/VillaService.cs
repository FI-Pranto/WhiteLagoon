using WhiteLagoon.Web.Models;
using WhiteLagoon.Web.Repository.IRepository;
using WhiteLagoon.Web.Service.IService;

namespace WhiteLagoon.Web.Service
{
    public class VillaService : IVillaService
    {
        private readonly IVillaRepository _villaRepository;
        public VillaService(IVillaRepository villaRepository) { 
        
        _villaRepository = villaRepository;

        }
        public void AddVilla(Villa villa)
        {
            _villaRepository.Add(villa);
        }

        public void DeleteVilla(Villa villa)
        {
            //var  villa=GetVillaById(id);
            _villaRepository.Delete(villa);
        }

        public IEnumerable<Villa> GetAllVilla(string? includeProp=null)
        {

          var villas=_villaRepository.GetAll(includeProp);

            return villas;
        }

        public Villa GetVillaById(int? id)
        {
            return _villaRepository.Get(id);
        }

        public void UpdateVilla(Villa villa)
        {
            
            _villaRepository.Update(villa);
        }
    }
}   
