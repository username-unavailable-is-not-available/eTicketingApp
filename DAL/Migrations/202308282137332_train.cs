namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class train : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrainName = c.String(nullable: false),
                        TrainNo = c.String(nullable: false),
                        TrainRoute = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trains");
        }
    }
}
