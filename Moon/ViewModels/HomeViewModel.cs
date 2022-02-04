using Moon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.ViewModels
{
    public class HomeViewModel
    {
       
        public List<Service> Services { get; set; }
        public List<Counter> Counters { get; set; }
        public List<Feature> Features { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Pricing> Pricings { get; set; }
        public List<Client> Clients { get; set; }
        public List<Navbar> Navbars { get; set; }


    }
}
