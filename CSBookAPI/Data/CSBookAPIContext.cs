using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSBookAPI.Domain;

namespace CSBookAPI.Data
{
    public class CSBookAPIContext : DbContext
    {
        public CSBookAPIContext (DbContextOptions<CSBookAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CSBookAPI.Domain.Book> Book { get; set; } = default!;
    }
}
