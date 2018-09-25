namespace mvcOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoviesTable12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "MovieTypeId");
            AddForeignKey("dbo.Movies", "MovieTypeId", "dbo.Movietypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieTypeId", "dbo.Movietypes");
            DropIndex("dbo.Movies", new[] { "MovieTypeId" });
            DropColumn("dbo.Movies", "MovieTypeId");
        }
    }
}
