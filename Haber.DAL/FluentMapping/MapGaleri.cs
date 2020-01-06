using Haber.Entities.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haber.DAL.FluentMapping
{
   public class MapGaleri: EntityTypeConfiguration<Galeri>
    {
        public MapGaleri()
        {
            ToTable("Galeri");
            HasKey(x => x.Id);
            Property(x => x.ResimYolu).IsRequired().HasMaxLength(250).HasColumnType("varchar");
            //Property(x => x.HaberId).IsRequired();

        }
    }
}
