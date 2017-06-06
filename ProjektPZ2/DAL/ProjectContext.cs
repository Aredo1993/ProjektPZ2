using ProjektPZ2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjektPZ2.DAL
{
    public class ProjectContext:DbContext
    {
        public ProjectContext() : base("DefaultConnection") { }


        public DbSet<Profile> Profile { get; set; }
        public DbSet<PrzetargModels> Przetargi { get; set; }
        public DbSet<OfertaModels> Oferty { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}