using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PropertyOption
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
        public string Option { get; set; }
    }
}
