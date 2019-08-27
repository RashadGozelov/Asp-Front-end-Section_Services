using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson21Area.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required, StringLength(100)]

        public string Title { get; set; }
        [Required, StringLength(200)]

        public string Description { get; set; }
        [Required, StringLength(100)]

        public string Image { get; set; }

    }
}
