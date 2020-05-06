using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Traistar_Bianca_Rp.Models;

namespace Asp_Traistar_Bianca_Rp.Data
{
    public class Asp_Traistar_Bianca_RpContext : DbContext
    {
        public Asp_Traistar_Bianca_RpContext (DbContextOptions<Asp_Traistar_Bianca_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Traistar_Bianca_Rp.Models.Movie> Movie { get; set; }
    }
}
