using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rosa.Models;
using Rosa.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Rosa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductBLL _productBLL;

        public HomeController(ILogger<HomeController> logger, IProductBLL productBLL)
        {
            _productBLL = productBLL;
            _logger = logger;
        }

        public IActionResult Index(SearchViewModel searchVm = null)
        {
            var products = _productBLL.GetAll();
            if (searchVm != null &&  searchVm.SearchTerm !=null)
                products = products.Where(p => p.Name.ToLower().Contains(searchVm.SearchTerm.ToLower()));

            return View(new HomeViewModel { Products = products.Take(15)
                .OrderByDescending(p => p.CreationDate).ToList()});
        }

        public IActionResult Slider()
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
