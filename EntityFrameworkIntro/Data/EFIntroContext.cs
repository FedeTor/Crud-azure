using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkIntro.Models;

namespace EntityFrameworkIntro.Data
{
    public class EFIntroContext : DbContext
    {
        public EFIntroContext (DbContextOptions<EFIntroContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameworkIntro.Models.Clients> Clients { get; set; }
    }
}
