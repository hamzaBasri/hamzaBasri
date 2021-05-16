using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Rosa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.Controllers
{
    public class ProductTypeController : Controller
    {
        readonly IProductTypeBLL _productTypeBLL;
        public ProductTypeController(IProductTypeBLL productTypeBLL)
        {
            _productTypeBLL = productTypeBLL;
        }
        public IActionResult Liste()
        {
            IEnumerable<ProductTypeViewModel> product = _productTypeBLL.GetAll().Select(ProductTypeViewModel.FromModel).ToList();
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var productTypeVM = new ProductTypeViewModel();
            if (id > 0)
                productTypeVM = _productTypeBLL.GetAll().Where(p => p.Id == id).Select(ProductTypeViewModel.FromModel).FirstOrDefault();
            return View("Create", productTypeVM);
        }

        public IActionResult Save(ProductTypeViewModel productTypeVM)
        {
            var productType = productTypeVM.ToModel();
            _productTypeBLL.Save(productType);
            return View(ProductTypeViewModel.FromModel(productType));

        }
    }
}
