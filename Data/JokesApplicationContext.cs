using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesApplication.Models;

namespace JokesApplication.Data
{
    public class JokesApplicationContext : DbContext
    {
        public JokesApplicationContext (DbContextOptions<JokesApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<JokesApplication.Models.Joke> Joke { get; set; } = default!;
    }
}
