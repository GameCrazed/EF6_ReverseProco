

namespace Generator
{

    public class WaltMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Walt>
    {
        public WaltMapping()
            : this("dbo")
        {
        }

        public WaltMapping(string schema)
        {
            ToTable("WALT", schema);
            HasKey(x => x.Walt999);

            Property(x => x.TempDummy).HasColumnName(@"tempDummy").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Walt010).HasColumnName(@"WALT010").HasColumnType("int").IsRequired();
            Property(x => x.Walt020).HasColumnName(@"WALT020").HasColumnType("datetime").IsRequired();
            Property(x => x.Walt030).HasColumnName(@"WALT030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Walt040).HasColumnName(@"WALT040").HasColumnType("int").IsRequired();
            Property(x => x.Walt050).HasColumnName(@"WALT050").HasColumnType("int").IsRequired();
            Property(x => x.Walt060).HasColumnName(@"WALT060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Walt070).HasColumnName(@"WALT070").HasColumnType("datetime").IsRequired();
            Property(x => x.Walt080).HasColumnName(@"WALT080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Walt999).HasColumnName(@"WALT999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
