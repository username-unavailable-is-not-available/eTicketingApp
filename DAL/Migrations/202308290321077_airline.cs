namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class airline : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airlines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AirlineName = c.String(nullable: false),
                        AirlineNo = c.Int(nullable: false),
                        detailes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Airlines");
        }
    }
}
