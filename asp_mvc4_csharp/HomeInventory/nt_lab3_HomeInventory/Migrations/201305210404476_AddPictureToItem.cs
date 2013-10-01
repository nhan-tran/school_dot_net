namespace nt_lab3_HomeInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPictureToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Picture");
        }
    }
}
