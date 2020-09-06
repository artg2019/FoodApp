namespace FoodApp.BL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reciptes", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Reciptes", "FoodTypeId", "dbo.FoodTypes");
            DropForeignKey("dbo.Reciptes", "ManualId", "dbo.RecipteManuals");
            DropIndex("dbo.Reciptes", new[] { "ProductId" });
            DropIndex("dbo.Reciptes", new[] { "ManualId" });
            DropIndex("dbo.Reciptes", new[] { "FoodTypeId" });
            RenameColumn(table: "dbo.Reciptes", name: "ProductId", newName: "Products_Id");
            RenameColumn(table: "dbo.Reciptes", name: "FoodTypeId", newName: "FoodTypes_Id");
            RenameColumn(table: "dbo.Reciptes", name: "ManualId", newName: "Manual_Id");
            AlterColumn("dbo.Reciptes", "Products_Id", c => c.Int());
            AlterColumn("dbo.Reciptes", "Manual_Id", c => c.Int());
            AlterColumn("dbo.Reciptes", "FoodTypes_Id", c => c.Int());
            CreateIndex("dbo.Reciptes", "FoodTypes_Id");
            CreateIndex("dbo.Reciptes", "Manual_Id");
            CreateIndex("dbo.Reciptes", "Products_Id");
            AddForeignKey("dbo.Reciptes", "Products_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.Reciptes", "FoodTypes_Id", "dbo.FoodTypes", "Id");
            AddForeignKey("dbo.Reciptes", "Manual_Id", "dbo.RecipteManuals", "Id");
            DropColumn("dbo.Products", "RecipteId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "RecipteId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Reciptes", "Manual_Id", "dbo.RecipteManuals");
            DropForeignKey("dbo.Reciptes", "FoodTypes_Id", "dbo.FoodTypes");
            DropForeignKey("dbo.Reciptes", "Products_Id", "dbo.Products");
            DropIndex("dbo.Reciptes", new[] { "Products_Id" });
            DropIndex("dbo.Reciptes", new[] { "Manual_Id" });
            DropIndex("dbo.Reciptes", new[] { "FoodTypes_Id" });
            AlterColumn("dbo.Reciptes", "FoodTypes_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Reciptes", "Manual_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Reciptes", "Products_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Reciptes", name: "Manual_Id", newName: "ManualId");
            RenameColumn(table: "dbo.Reciptes", name: "FoodTypes_Id", newName: "FoodTypeId");
            RenameColumn(table: "dbo.Reciptes", name: "Products_Id", newName: "ProductId");
            CreateIndex("dbo.Reciptes", "FoodTypeId");
            CreateIndex("dbo.Reciptes", "ManualId");
            CreateIndex("dbo.Reciptes", "ProductId");
            AddForeignKey("dbo.Reciptes", "ManualId", "dbo.RecipteManuals", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reciptes", "FoodTypeId", "dbo.FoodTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reciptes", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
