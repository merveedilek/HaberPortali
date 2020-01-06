using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.FluentMapping
{
   public class MapYorum: EntityTypeConfiguration<Yorum>
    {
        public MapYorum()
        {
            ToTable("Yorum");
            HasKey(x => x.Id);
            Property(x => x.Adi).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.Soyadi).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.Email).IsOptional().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.Mesaj).IsRequired().HasMaxLength(500).HasColumnType("varchar");
            Property(x => x.OlusturmaTarihi).IsRequired().HasColumnType("date");
            Property(x => x.HaberId).IsRequired();




        }
    }
}
