namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAirplaneEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airplanes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AirplaneName = c.String(),
                        FlightRoute = c.String(),
                        TicketPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VehicleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Airplanes", "VehicleId", "dbo.Vehicles");
            DropIndex("dbo.Airplanes", new[] { "VehicleId" });
            DropTable("dbo.Airplanes");
        }
    }
}
