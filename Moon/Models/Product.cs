using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
