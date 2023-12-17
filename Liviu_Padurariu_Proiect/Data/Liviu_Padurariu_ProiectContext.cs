using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Liviu_Padurariu_Proiect.Models;

namespace Liviu_Padurariu_Proiect.Data
{
    public class Liviu_Padurariu_ProiectContext : DbContext
    {
        public Liviu_Padurariu_ProiectContext (DbContextOptions<Liviu_Padurariu_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Liviu_Padurariu_Proiect.Models.Car> Car { get; set; } = default!;
        public DbSet<Liviu_Padurariu_Proiect.Models.Color> Color { get; set; } = default!;
        public DbSet<Liviu_Padurariu_Proiect.Models.CarMaker> CarMaker { get; set; } = default!;
        public DbSet<Liviu_Padurariu_Proiect.Models.Location> Location { get; set; } = default!;
        public DbSet<Liviu_Padurariu_Proiect.Models.Rental> Rental { get; set; } = default!;
        public DbSet<Liviu_Padurariu_Proiect.Models.Role> Role { get; set; } = default!;
        public DbSet<Liviu_Padurariu_Proiect.Models.Transmission> Transmission { get; set; } = default!;
        public DbSet<Liviu_Padurariu_Proiect.Models.User> User { get; set; } = default!;
    }
}
