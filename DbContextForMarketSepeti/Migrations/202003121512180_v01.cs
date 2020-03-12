namespace DbContextForMarketSepeti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductMarkets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        MarketId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markets", t => t.MarketId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.MarketId);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Address = c.String(nullable: false, maxLength: 350),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        OpeningTime = c.String(nullable: false, maxLength: 4),
                        ClosingTime = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCartProductMarkets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShoppingCartId = c.Int(nullable: false),
                        ProductMarketId = c.Int(nullable: false),
                        NumberOfProduct = c.Int(nullable: false),
                        APruductPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductMarkets", t => t.ProductMarketId, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCartId, cascadeDelete: true)
                .Index(t => t.ShoppingCartId)
                .Index(t => t.ProductMarketId);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsItComplete = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                        TimeToComplate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AspNetUserId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 50),
                        Address = c.String(maxLength: 350),
                        Email = c.String(maxLength: 150),
                        Phone = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCarts", "UserId", "dbo.Users");
            DropForeignKey("dbo.ShoppingCartProductMarkets", "ShoppingCartId", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCartProductMarkets", "ProductMarketId", "dbo.ProductMarkets");
            DropForeignKey("dbo.ProductMarkets", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductMarkets", "MarketId", "dbo.Markets");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ShoppingCarts", new[] { "UserId" });
            DropIndex("dbo.ShoppingCartProductMarkets", new[] { "ProductMarketId" });
            DropIndex("dbo.ShoppingCartProductMarkets", new[] { "ShoppingCartId" });
            DropIndex("dbo.ProductMarkets", new[] { "MarketId" });
            DropIndex("dbo.ProductMarkets", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Users");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.ShoppingCartProductMarkets");
            DropTable("dbo.Markets");
            DropTable("dbo.ProductMarkets");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
