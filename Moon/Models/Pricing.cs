using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public int Storage { get; set; }
        public string Subtitle { get; set; }
        public double Price { get; set; }
        public string ButtonText { get; set; }
    }
}
