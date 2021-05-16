using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using Rosa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Rosa.Controllers.api
{
    public class ProductController : BaseApiController
    {
        private IProductBLL _productBLL;

        public ProductController(IProductBLL productBLL)
        {
            _productBLL = productBLL;
        }

        public ActionResult<List<ProductEditViewModel>> List()
        {
            var productVMs = _productBLL.GetAll().Select(ProductListViewModel.FromModel).ToList();

            return Ok(new { data = productVMs});

        }
        
        

    }
}
