using BLL.interfaces;
using BLL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using Rosa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rosa.Controllers
{
    public class ProductController : BaseMvcController
    {
        readonly IProductBLL _productBLL;
        readonly IProductTypeBLL _productTypeBLL;


        public ProductController(IProductBLL productBLL, IProductTypeBLL productTypeBLL, IWebHostEnvironment env) : base(env)
        {
            _productBLL = productBLL;
            _productTypeBLL = productTypeBLL;
        }

        public IActionResult List(SearchViewModel searchVm = null)
        {
            var products = _productBLL.GetAllIncludingType();
            if (searchVm != null)
                products = products.Where(p => p.Name == searchVm.SearchTerm);

            return View(ProductListViewModel.FromModels(products));
        }

        public IActionResult Liste()
        {
            var product = _productBLL.GetAllIncludingType().Select(ProductListViewModel.FromModel).ToList();
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var productVM = new ProductEditViewModel();
            var productTypes = _productTypeBLL.GetAll();
            
            var product = _productBLL.GetByIdIncludingAll(id);
            productVM = ProductEditViewModel.FromModel(product, productTypes);
            
            ViewData["Title"] = productVM.IsCreateMode ? "Create" : "Update";



            return View(productVM);
        }

        public IActionResult Save(ProductEditViewModel productVM)
        {
            var product = productVM.ToModel();
            product.Image = UploadImage(productVM.Image);
            _productBLL.Save(product);
            SetMessage($"Product Id {product.Id} Saved Succesfuly");
            return RedirectToAction("Liste");
        }

        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                SetMessage($"Product Id {id} is not exist ", "error");
                return RedirectToAction("Liste");
            }
            _productBLL.DeleteById(id);
            SetMessage($"Product Id {id} Deleted Succesfuly");

            return RedirectToAction("Liste");



        }
        [Route("/product/{id}")]
        public IActionResult ProductShow(int id)
        {
            //var productVM = new ProductShowViewModel();
            //var productTypes = _productTypeBLL.GetAll();
            var product = _productBLL.GetByid(id);
            var productVM = ProductShowViewModel.FromModel(product);
            return View(productVM);
        }

    }
}
