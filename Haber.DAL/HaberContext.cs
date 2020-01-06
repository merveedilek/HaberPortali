using Haber.DAL.FluentMapping;
using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL
{
   public class HaberContext:DbContext
    {
        public HaberContext() : base(nameOrConnectionString: "HaberContext")
        //: base("") //connectionPath
        {
            Configuration.LazyLoadingEnabled = false;
            //Database.Connection.ConnectionString = @"Server=;Database=;Uid=;Pwd=;";

            var value = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Entities.EF.Haber> Haber { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        public DbSet<Galeri> Galeri { get; set; }
        public DbSet<Kategori> Kategori { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MapKategori());
            modelBuilder.Configurations.Add(new MapKullanici());
            modelBuilder.Configurations.Add(new MapYorum());
            modelBuilder.Configurations.Add(new MapGaleri());
            modelBuilder.Configurations.Add(new MapHaber());

        }
    }
}
