using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Turcu_Alexandru_Gabriel_Lab2.Models;

namespace Turcu_Alexandru_Gabriel_Lab2.Data
{
    public class Turcu_Alexandru_Gabriel_Lab2Context : DbContext
    {
        public Turcu_Alexandru_Gabriel_Lab2Context (DbContextOptions<Turcu_Alexandru_Gabriel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Turcu_Alexandru_Gabriel_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Turcu_Alexandru_Gabriel_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
