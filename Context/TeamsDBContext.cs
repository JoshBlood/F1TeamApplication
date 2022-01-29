using F1TeamApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1TeamApplication.Context
{
    public class TeamsDBContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        public TeamsDBContext(DbContextOptions<TeamsDBContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().ToTable("Teams");
        }
    }
}
