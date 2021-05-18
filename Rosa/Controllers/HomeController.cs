

using BLL.interfaces;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
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
        private readonly ICarouselBLL _carouselBLL;



        public HomeController(ILogger<HomeController> logger, IProductBLL productBLL, ICarouselBLL carouselBLL)
        {
            _productBLL = productBLL;
            _logger = logger;
            _carouselBLL = carouselBLL;
        }

        public IActionResult Index(SearchViewModel searchVm = null)
        {
            IEnumerable<Product> products = GetProductsAndSearchIfPossible(searchVm);

            return View(new HomeViewModel
            {
                Products = products.Take(15).OrderByDescending(p => p.CreationDate).Select(ProductListViewModel.FromModel).ToList(),
                Carousels = _carouselBLL.GetAllActive().Select(CarouselListViewModel.FromModel).ToList()
            }
            );
        }

        private IEnumerable<Product> GetProductsAndSearchIfPossible(SearchViewModel searchVm)
        {
            var products = _productBLL.GetAll();
            if (searchVm != null && searchVm.SearchTerm != null)
                products = products.Where(p => p.Name.ToLower().Contains(searchVm.SearchTerm.ToLower()));
            return products;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
