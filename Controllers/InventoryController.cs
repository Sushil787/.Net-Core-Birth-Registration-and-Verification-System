using AspnetIdentityRoleBasedTutorial.Data;
using AspnetIdentityRoleBasedTutorial.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspnetIdentityRoleBasedTutorial.Controllers
{
    [Authorize(Roles ="Admin")]
    public class InventoryController : Controller
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public InventoryController(ApplicationDbContext applicationDbContext){
            this._applicationDbContext = applicationDbContext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {   
            var bacchas = _applicationDbContext.baccha.ToList<BacchaModel>();
            if(bacchas != null){
                return View(bacchas);
            }
            return View();
        }

        public async Task<IActionResult> Verify(Guid Id){
            Console.WriteLine("Verify Called");
            Console.WriteLine(Id);
            var bacchas = _applicationDbContext.baccha.Find(Id);
            bacchas!.IsVerified = true;
            await _applicationDbContext.SaveChangesAsync();
            return RedirectToAction("GetAll");
        }
    }
}
