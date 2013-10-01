namespace nt_lab3_HomeInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Policies",
                c => new
                    {
                        PolicyId = c.Int(nullable: false, identity: true),
                        PolicyName = c.String(),
                        PolicyNumber = c.String(),
                        CompanyName = c.String(),
                        PhoneNumber = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PolicyId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Shortname = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CategoryId = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                        Model = c.String(),
                        Identifier = c.String(),
                        PurchaseDate = c.DateTime(nullable: false),
                        PurchasePrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManufacturerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.ManufacturerId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Items", new[] { "ManufacturerId" });
            DropIndex("dbo.Items", new[] { "CategoryId" });
            DropForeignKey("dbo.Items", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Items", "CategoryId", "dbo.Categories");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
            DropTable("dbo.Policies");
        }
    }
}
