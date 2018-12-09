namespace MVC_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class score2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Score", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Score", c => c.Int(nullable: false));
        }
    }
}
