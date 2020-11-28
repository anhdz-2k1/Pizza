using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pizza.Models;
using Pizza.Models.ViewModels;
namespace Pizza.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }


        public int PageSize = 2;


        public ViewResult Index(string category, int productPage = 1)
           => View(new ProductsListViewModel
           {
               Products = repository.Products
               .Where(p => category == null || p.Category == category)
               .OrderBy(p => p.ProductID)
               .Skip((productPage - 1) * PageSize)
               .Take(PageSize),
               PagingInfo = new PagingInfo
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                    //TotalItems = repository.Products.Count()

                    TotalItems = category == null ?
                   repository.Products.Count() :
                   repository.Products.Where(
                       e => e.Category == category).Count()
               },
           });




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
