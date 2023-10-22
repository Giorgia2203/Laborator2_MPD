using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Laborator2_MPD.Models;

namespace Laborator2_MPD.Data
{
    public class Laborator2_MPDContext : DbContext
    {
        public Laborator2_MPDContext (DbContextOptions<Laborator2_MPDContext> options)
            : base(options)
        {
        }

        public DbSet<Laborator2_MPD.Models.Book> Book { get; set; } = default!;

        public DbSet<Laborator2_MPD.Models.Publisher>? Publisher { get; set; }

        public DbSet<Laborator2_MPD.Models.Author>? Author { get; set; }
    }
}
