using HoptSport.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HoptSport.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        
        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}