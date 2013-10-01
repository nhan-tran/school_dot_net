namespace MvcMovieCST238.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDirectorIDMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DirectorID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "DirectorID");
        }
    }
}
