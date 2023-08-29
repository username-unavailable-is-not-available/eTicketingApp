namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class route : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RouteAndSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RouteID = c.Int(nullable: false),
                        RouteName = c.String(),
                        VehicleType = c.String(),
                        VehicleName = c.String(),
                        StartPoint = c.String(),
                        EndPoint = c.String(),
                        DepartedTime = c.String(),
                        ArrivalTime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RouteAndSchedules");
        }
    }
}
