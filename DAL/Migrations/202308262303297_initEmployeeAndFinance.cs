namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class initEmployeeAndFinance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeManages",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.FinanceManages",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    EmployeeId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeManages", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.FinanceManages", "EmployeeId", "dbo.EmployeeManages");
            DropIndex("dbo.FinanceManages", new[] { "EmployeeId" });
            DropTable("dbo.FinanceManages");
            DropTable("dbo.EmployeeManages");
        }
    }
}
