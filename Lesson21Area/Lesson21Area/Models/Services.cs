using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson21Area.Models
{
    public class Services
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This input required"), StringLength(100, ErrorMessage = "This symbol few than 100")]

        public string Title { get; set; }
        [Required(ErrorMessage = "This input required"), StringLength(400, ErrorMessage = "This symbol few than 400")]

        public string Description { get; set; }
        [Required(ErrorMessage = "This input required"), StringLength(100, ErrorMessage = "This symbol few than 100")]

        public string Iconclass { get; set; }

    }
}
