namespace Haber.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galeri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResimYolu = c.String(nullable: false, maxLength: 250, unicode: false),
                        HaberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Haber", t => t.HaberId, cascadeDelete: true)
                .Index(t => t.HaberId);
            
            CreateTable(
                "dbo.Haber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(nullable: false, maxLength: 100, unicode: false),
                        İcerik = c.String(nullable: false, unicode: false, storeType: "text"),
                        OnaylandiMi = c.Boolean(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false, storeType: "date"),
                        GuncellenmeTarihi = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanıcı", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanıcı",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50, unicode: false),
                        Soyadi = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(nullable: false, maxLength: 16, unicode: false),
                        Roller = c.Int(nullable: false),
                        OnaylandiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yorum",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 50, unicode: false),
                        Soyadi = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Mesaj = c.String(nullable: false, maxLength: 500, unicode: false),
                        OnaylandiMi = c.Boolean(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false, storeType: "date"),
                        HaberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Haber", t => t.HaberId, cascadeDelete: true)
                .Index(t => t.HaberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorum", "HaberId", "dbo.Haber");
            DropForeignKey("dbo.Haber", "KullaniciId", "dbo.Kullanıcı");
            DropForeignKey("dbo.Haber", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.Galeri", "HaberId", "dbo.Haber");
            DropIndex("dbo.Yorum", new[] { "HaberId" });
            DropIndex("dbo.Haber", new[] { "KullaniciId" });
            DropIndex("dbo.Haber", new[] { "KategoriId" });
            DropIndex("dbo.Galeri", new[] { "HaberId" });
            DropTable("dbo.Yorum");
            DropTable("dbo.Kullanıcı");
            DropTable("dbo.Kategori");
            DropTable("dbo.Haber");
            DropTable("dbo.Galeri");
        }
    }
}
