using Lesson21Area.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson21Area.ViewModel
{
    public class HomeModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Description> Descriptions { get; set; }
        public IEnumerable<Welcome> Welcomes { get; set; }
        public IEnumerable<WhatWeDo> WhatWeDos { get; set; }
        public IEnumerable<Services> Servicess { get; set; }
    }
}
