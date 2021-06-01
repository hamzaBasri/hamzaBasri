using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Rosa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.Controllers
{
    public class OrderItemController : Controller
    {
        readonly IOrderItemBLL _orderItemBLL;

        public OrderItemController(IOrderItemBLL orderItemBLL)
        {
            _orderItemBLL = orderItemBLL;
        }

        public IActionResult Index()
        {
            return View();
        }
        
    }
}
