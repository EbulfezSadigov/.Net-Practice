using Practice_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.ViewModel
{
    public class HomeViewModel
    {
        public List<Slider> sliders { get; set; }
        public List<Policy> policies { get; set; }
        public List<Product> products { get; set; }
    }
}
