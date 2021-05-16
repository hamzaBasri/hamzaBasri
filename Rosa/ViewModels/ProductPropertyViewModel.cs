using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class ProductPropertyViewModel
    {


        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public decimal? Cost { get; set; }
        public int OptionId { get; set; }
        public bool HasCost => Cost > 0;
    

       public static ProductPropertyViewModel FromModel(ProductProperty pp)
        {
            return new ProductPropertyViewModel();
        }

    }
}
