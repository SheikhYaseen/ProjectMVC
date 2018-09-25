namespace mvcOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoviesTable124 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movietypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movietypes", "Name", c => c.String(nullable: false));
        }
    }
}
