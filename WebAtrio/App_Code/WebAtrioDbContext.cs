using System.Data.Entity;

namespace WebAtrio
{
    public class WebAtrioDbContext : DbContext
    {
        #region Entities
        public DbSet<Personne> Personnes { get; set; }
        #endregion

        public WebAtrioDbContext()
            : base("WebAtrioDbContext")
        { 
        }
    }
}
