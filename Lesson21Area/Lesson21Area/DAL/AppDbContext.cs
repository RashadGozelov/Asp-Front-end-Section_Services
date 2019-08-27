using Lesson21Area.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson21Area.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Welcome> Welcomes { get; set; }
        public DbSet<WhatWeDo> WhatWeDos { get; set; }
        public DbSet<Services> Servicess { get; set; }
    }
}