namespace MVC_site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoList",
                c => new
                    {
                        equipmentId = c.String(nullable: false, maxLength: 128),
                        EquipmentType = c.String(maxLength: 150),
                        EquipmentLocation = c.String(maxLength: 150),
                        EquipmentCondition = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.equipmentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TodoList");
        }
    }
}
