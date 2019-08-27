using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson21Area.Models
{
    public class Description
    {
        public int Id { get; set; }
        [Required, StringLength(100)]

        public string Title { get; set; }
        [Required, StringLength(400)]

        public string Descrp { get; set; }

    }
}
