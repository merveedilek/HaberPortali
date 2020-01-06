using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Haber.DAL.FluentMapping
{
   public class MapHaber : EntityTypeConfiguration<Entities.EF.Haber>
    {
        public MapHaber()
        {
            ToTable("Haber");
            HasKey(x => x.Id);
            Property(x => x.Baslik).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            Property(x => x.İcerik).IsRequired().HasColumnType("text");
            Property(x => x.OlusturulmaTarihi).IsRequired().HasColumnType("date");
            Property(x => x.GuncellenmeTarihi).IsOptional().HasColumnType("date");
            Property(x => x.KategoriId).IsRequired();
            Property(x => x.KullaniciId).IsRequired();

        }
    }
}
