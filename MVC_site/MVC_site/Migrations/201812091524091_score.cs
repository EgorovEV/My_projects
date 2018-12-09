namespace MVC_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class score : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Score");
        }
    }
}
