using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.ViewModels
{
    public class PropertyOptionViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public decimal Cost { get; set; }

        internal static PropertyOptionViewModel FromModel(PropertyOption po)
        {
            return new PropertyOptionViewModel
            {
                Id= po.Id,
                Text =po.Option,
                Cost = po.Cost
            };
        }
    }
}
