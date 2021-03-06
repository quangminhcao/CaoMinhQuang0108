using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaoMinhQuang108.Models;
using CAOMINHQUANG108.model;

    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext (DbContextOptions<ApplicationDBcontext> options)
            : base(options)
        {
        }
        public DbSet<CaoMinhQuang108.Models.UniversityCMQ108> UniversityCMQ108 { get; set; }
        public DbSet<CAOMINHQUANG108.model.CMQ108> CMQ108 { get; set; }

    }
