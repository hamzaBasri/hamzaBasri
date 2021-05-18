using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<CarouselListViewModel> Carousels { get; set; }
        public IEnumerable<ProductListViewModel> Products  { get; set; }
    }
}
