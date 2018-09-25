namespace mvcOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoviesTable111478954 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieTypes", "Name", c => c.String(nullable: false));
        }
    }
}
