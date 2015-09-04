using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using TemaXP.ModelLayer;

namespace TemaXP.DBLayer
{
    public partial class DBContext : DbContext
    {
        public DbSet<Painting> Paintings { get; set; }

        static DBContext()
        {
            Database.SetInitializer<DBContext>(null);
        }

        public DBContext()
            : base("Name=TemaXPContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
