using System.Data.Entity;
using TemaXP.ModelLayer;

namespace TemaXP.DBLayer
{
    public partial class DBContext : DbContext
    {
        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Auction> Auctions { get; set; }

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