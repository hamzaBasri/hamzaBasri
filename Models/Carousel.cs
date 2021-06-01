using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Carousel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
    }
}
