using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Rosa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.Controllers
{
    public class OrderController : Controller
    {
        readonly IOrderBLL _orderBLL;

        public OrderController(IOrderBLL orderBLL)
        {
            _orderBLL = orderBLL;
        }
        public IActionResult Liste()
        {
            IEnumerable<OrderViewModel> product = _orderBLL.GetAll().Select(OrderViewModel.FromModel).ToList();
            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var orderVM = new OrderViewModel();
            if(id > 0)
            orderVM = _orderBLL.GetAll().Where(p => p.Id == id).Select(OrderViewModel.FromModel).FirstOrDefault();
            return View("Created", orderVM);
        }
        public IActionResult Save(OrderViewModel orderVM)
        {
            var order = orderVM.ToModel();
            _orderBLL.Save(order);
            return View(OrderViewModel.FromModel(order));
        }
    }
}
