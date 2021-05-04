using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAtrio.Dao.Entity;

namespace WebAtrio.Dao
{
    public class WebAtrioDbContext : DbContext
    {
        #region Entities
        public DbSet<Personne> Cycles { get; set; }
        #endregion

        public WebAtrioDbContext()
            : base("WebAtrioDbContext")
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
