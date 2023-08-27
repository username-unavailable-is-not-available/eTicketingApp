namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initDBAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketManages",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Vehicle = c.String(),
                    Class = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.UserManages",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.UserManages");
            DropTable("dbo.TicketManages");
        }
    }
}
