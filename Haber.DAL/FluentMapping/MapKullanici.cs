using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.FluentMapping
{
   public class MapKullanici: EntityTypeConfiguration<Kullanici>
    {
        public MapKullanici()
        {
            ToTable("Kullanıcı");
            HasKey(x => x.Id);
            Property(x => x.Adi).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x=>x.Soyadi).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.Email).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.Password).IsRequired().HasMaxLength(16).HasColumnType("varchar");
           



        }
    }
}
