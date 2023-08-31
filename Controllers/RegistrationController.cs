using AspnetIdentityRoleBasedTutorial.Data;
using AspnetIdentityRoleBasedTutorial.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AspnetIdentityRoleBasedTutorial.Controllers
{
    [Authorize(Roles ="User")]
    public class RegistrationController : Controller

    {
private readonly ApplicationDbContext _applicationDbContext;

        public RegistrationController(ApplicationDbContext applicationDbContext){
            this._applicationDbContext = applicationDbContext;
        }

        public IActionResult RegisterBaby()
        {
         
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(BacchaModel newBaccha){
            var Id = Guid.NewGuid();

             var bacchaModel =new BacchaModel(){
                Id = Id,
                Name = newBaccha.Name,
                Image = newBaccha.Image,
                FatherName = newBaccha.FatherName,
                MotherName = newBaccha.MotherName,
                GrandFatherName = newBaccha.GrandFatherName,
                GrandMotherName = newBaccha.GrandMotherName,
                HomeLocation = newBaccha.HomeLocation,
                HospitalName = newBaccha.HospitalName,
                HospitaLocation = newBaccha.HomeLocation,
                DateOfBirth = newBaccha.DateOfBirth,
                IsVerified = false
            };
            await _applicationDbContext.baccha.AddAsync(bacchaModel);
            await _applicationDbContext.SaveChangesAsync();
            return RedirectToAction("ShowId" ,new { Id });
        // return RedirectToAction("Index","Home");

          
        }

        public IActionResult ShowId(Guid Id){
            ViewBag.Id = Id;
            return View();
        }
}
}
