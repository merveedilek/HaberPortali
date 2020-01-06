using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.FluentMapping
{
   public class MapKategori: EntityTypeConfiguration<Kategori>
    {
        public MapKategori()
        {
            ToTable("Kategori");
            HasKey(x => x.Id);
            Property(x => x.KategoriAdi).IsRequired().HasMaxLength(50).HasColumnType("varchar");
        }
    }
}
