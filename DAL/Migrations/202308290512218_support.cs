namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class support : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerSupports",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        RequestId = c.Int(nullable: false),
                        RequestType = c.String(),
                        CustomerId = c.Int(nullable: false),
                        CustomerName = c.String(),
                        ContactDetails = c.String(),
                        SupportDetails = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerSupports");
        }
    }
}
