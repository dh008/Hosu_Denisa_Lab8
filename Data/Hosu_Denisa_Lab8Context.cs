using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hosu_Denisa_Lab8.Models;

namespace Hosu_Denisa_Lab8.Data
{
    public class Hosu_Denisa_Lab8Context : DbContext
    {
        public Hosu_Denisa_Lab8Context (DbContextOptions<Hosu_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Hosu_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Hosu_Denisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Hosu_Denisa_Lab8.Models.Category> Category { get; set; }
    }
}
