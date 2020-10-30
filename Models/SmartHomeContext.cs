using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace SmartHomeServer.Models
{
    public class SmartHomeContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=SmartHome;user=root;password=Ebnilinde.17");
        }
    }
}
