using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Rosa.ViewModels
{
    public class OrderItemAddViewModel
    {
        public int ProductId { get; set; }

        public List<(int propertyId, int optionId)> Properties { get; set; }

    }
}
