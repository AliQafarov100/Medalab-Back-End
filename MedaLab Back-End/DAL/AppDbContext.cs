using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedaLab_Back_End.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedaLab_Back_End.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<ServiceCard> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
