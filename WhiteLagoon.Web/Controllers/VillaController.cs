using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Web.Models;
using WhiteLagoon.Web.Repository.IRepository;
using WhiteLagoon.Web.Service.IService;

namespace WhiteLagoon.Web.Controllers
{

    [Route("hotels")]
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;

        private readonly IUnitOfWork _unitOfWork;
        public VillaController(IVillaService villaService,IUnitOfWork unitOfWork)
        {
            _villaService = villaService;
            _unitOfWork = unitOfWork;
             
        }


        [HttpGet("")]
        [HttpGet("villas")]
        public IActionResult Index()
        {
            var villas = _villaService.GetAllVilla();
            return View(villas);
        }

        [HttpGet("add")]//<-this two must have same name always (i have checked with adding other name to route)
        public IActionResult AddVilla()
        {
            return View();
        }

        [HttpPost("add")]//<-this two must have same name always
        public IActionResult AddVilla([FromForm] Villa villa)
        {
            if (ModelState.IsValid)
            {

                _villaService.AddVilla(villa);
                _unitOfWork.Commit();

                return RedirectToAction("Index");

            }

            return View(villa);
        }
        [HttpGet("edit/{id?}")]//<----like previouly must be same route

        public IActionResult Edit(int? id)
        {
            if(id== null)
            {
                return NotFound();  
            }
            var villa = _villaService.GetVillaById(id);

            if (villa == null)
            {
                return NotFound();
            }
            return View(villa);

        }

        [HttpPost("edit/{id?}")]//<----like previouly must be same route and post cause sumitting form
        public IActionResult Edit(Villa villa)
        {
            if (ModelState.IsValid)
            {

                _villaService.UpdateVilla(villa);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(villa);

        }

        [HttpGet("delete/{id?}")]//<----like previouly must be same route

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var villa = _villaService.GetVillaById(id);

            if (villa == null)
            {
                return NotFound();
            }
            return View(villa);

        }

        [HttpPost("delete/{id?}")]//<----like previouly must be same route and post cause sumitting form
        public IActionResult Delete(Villa villa)
        {
            if (ModelState.IsValid)
            {

                _villaService.DeleteVilla(villa);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(villa);

        }

    }
}
