
using Rosa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rosa.Controllers.api
{
    public class OrderController : BaseApiController
    {
        public string AddToOrder(OrderItemAddViewModel vm)
        {
            return JsonConvert.SerializeObject(vm);
        }
    }
}
