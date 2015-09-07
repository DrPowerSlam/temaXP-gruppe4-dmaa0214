namespace TemaXP.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Author = c.String(),
                    Title = c.String(),
                    Year = c.Int(nullable: false),
                    Description = c.String(),
                    PurchasePrice = c.Double(nullable: false),
                    Interval = c.Int(nullable: false),
                    Image = c.String(),
                    MinPrice = c.Double(nullable: false),
                    Sold = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Arts");
        }
    }
}