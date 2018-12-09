namespace MVC_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipment2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TodoList", newName: "EquipmentList");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EquipmentList", newName: "TodoList");
        }
    }
}
