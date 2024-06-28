namespace Agri_Energy_Prototype_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SustainableFarmingHUBs",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductionDate = c.DateTime(nullable: false),
                        ProductionDetails = c.String(),
                        ProductUsage = c.String(),
                        Owner = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SustainableFarmingHUBs");
        }
    }
}
