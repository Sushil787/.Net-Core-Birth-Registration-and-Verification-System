using AspnetIdentityRoleBasedTutorial.Data;
using AspnetIdentityRoleBasedTutorial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;

namespace AspnetIdentityRoleBasedTutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(  ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        public async Task<IActionResult> Index(Guid Id)
        {  

            Console.WriteLine(Id);
            if(!Id.Equals(Guid.Empty)){
            var baccha = await _applicationDbContext.baccha.FindAsync(Id);
            if(baccha!=null){
                return View(baccha);
                
            }
            return View();
            }else{
               

                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       

        

    }
}