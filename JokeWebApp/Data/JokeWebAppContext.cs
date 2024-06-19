using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokeWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JokeWebApp.Data
{
    public class JokeWebAppContext : IdentityDbContext<IdentityUser>
    {
        public JokeWebAppContext (DbContextOptions<JokeWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<JokeWebApp.Models.Joke> Joke { get; set; } = default!;
    }
}
