using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlackShield.Infrastructure.Persistence;

public class ApplicationDbContext
    : IdentityDbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options
    ) : base(options)
    {
    }

    // Aquí irán tus DbSet más adelante
    // public DbSet<Guardia> Guardias { get; set; }
}
