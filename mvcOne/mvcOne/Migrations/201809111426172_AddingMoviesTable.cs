namespace mvcOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateReleased", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Date");
            DropColumn("dbo.Movies", "DateAddedInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "DateAddedInStock", c => c.DateTime());
            AddColumn("dbo.Movies", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "DateReleased");
        }
    }
}
