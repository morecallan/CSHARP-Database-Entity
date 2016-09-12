namespace NinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clans",
                c => new
                    {
                        ClanId = c.Int(nullable: false, identity: true),
                        ClanName = c.String(),
                    })
                .PrimaryKey(t => t.ClanId);
            
            CreateTable(
                "dbo.Ninjas",
                c => new
                    {
                        NinjaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ServedInOnibawan = c.Boolean(nullable: false),
                        ClanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NinjaId)
                .ForeignKey("dbo.Clans", t => t.ClanId, cascadeDelete: true)
                .Index(t => t.ClanId);
            
            CreateTable(
                "dbo.NinjaEquipments",
                c => new
                    {
                        NinjaEquipmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        Ninja_NinjaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NinjaEquipmentId)
                .ForeignKey("dbo.Ninjas", t => t.Ninja_NinjaId, cascadeDelete: true)
                .Index(t => t.Ninja_NinjaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NinjaEquipments", "Ninja_NinjaId", "dbo.Ninjas");
            DropForeignKey("dbo.Ninjas", "ClanId", "dbo.Clans");
            DropIndex("dbo.NinjaEquipments", new[] { "Ninja_NinjaId" });
            DropIndex("dbo.Ninjas", new[] { "ClanId" });
            DropTable("dbo.NinjaEquipments");
            DropTable("dbo.Ninjas");
            DropTable("dbo.Clans");
        }
    }
}
