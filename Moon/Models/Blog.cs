using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }

    }
}
