﻿using Project4_EntityFrameworkCodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkCodeFirstMovie.DAL.Context
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; } // movie sınıfını sql de movies tablosuna çevir
        public DbSet<Category> Categories { get; set; }

    }
}
