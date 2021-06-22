using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class PropertyViewModel
    {


        public int Id { get; set; }
        public string Name { get; set; }
        //public string PropertyValue { get; set; }
        //public decimal? Cost { get; set; }
        public int SelectedOptionId { get; set; }

        //public bool HasCost => Cost > 0;
        public List<PropertyOptionViewModel> Options { get; set; }
        public bool HasMultipleOptions => Options?.Count > 1;


        public static PropertyViewModel FromModel(Property pp)
        {
            return
                new PropertyViewModel
                {
                    Id = pp.Id,
                    Name = pp.Name,
                    Options = pp.Options.Select(PropertyOptionViewModel.FromModel).ToList()
                };
        }

    }
}
