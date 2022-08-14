namespace BL_azhans.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countrys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.factors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FactorNum = c.Int(nullable: false),
                        MakeFactorDate = c.DateTime(nullable: false),
                        personelsid = c.Int(),
                        personelname = c.String(),
                        passengersid = c.Int(),
                        passengername = c.String(),
                        transferid = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.passengers", t => t.passengersid)
                .ForeignKey("dbo.personels", t => t.personelsid)
                .ForeignKey("dbo.transfers", t => t.transferid)
                .Index(t => t.personelsid)
                .Index(t => t.passengersid)
                .Index(t => t.transferid);
            
            CreateTable(
                "dbo.passengers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Age = c.Int(nullable: false),
                        personelsId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        HCode = c.String(),
                        PictureAddress = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.personels", t => t.personelsId, cascadeDelete: true)
                .Index(t => t.personelsId);
            
            CreateTable(
                "dbo.personels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        name = c.String(),
                        code = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Personelstype = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.transfers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Transferttype = c.Int(nullable: false),
                        Internationalflytype = c.Int(),
                        Internationalflytypefarsi = c.String(),
                        Goingbackandforthornot = c.Boolean(nullable: false),
                        Passengertype = c.Int(nullable: false),
                        Passengertypefarsi = c.String(),
                        Goingdatetime = c.DateTime(nullable: false),
                        Backingdatetime = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sorcecity = c.String(),
                        destinationcity = c.String(),
                        sorcecountry = c.String(),
                        destinationcountry = c.String(),
                        personelsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.personels", t => t.personelsId, cascadeDelete: true)
                .Index(t => t.personelsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.transfers", "personelsId", "dbo.personels");
            DropForeignKey("dbo.factors", "transferid", "dbo.transfers");
            DropForeignKey("dbo.passengers", "personelsId", "dbo.personels");
            DropForeignKey("dbo.factors", "personelsid", "dbo.personels");
            DropForeignKey("dbo.factors", "passengersid", "dbo.passengers");
            DropIndex("dbo.transfers", new[] { "personelsId" });
            DropIndex("dbo.passengers", new[] { "personelsId" });
            DropIndex("dbo.factors", new[] { "transferid" });
            DropIndex("dbo.factors", new[] { "passengersid" });
            DropIndex("dbo.factors", new[] { "personelsid" });
            DropTable("dbo.transfers");
            DropTable("dbo.personels");
            DropTable("dbo.passengers");
            DropTable("dbo.factors");
            DropTable("dbo.Countrys");
            DropTable("dbo.Citys");
        }
    }
}
