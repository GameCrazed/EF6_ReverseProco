

namespace Generator
{

    public class VrelMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vrel>
    {
        public VrelMapping()
            : this("dbo")
        {
        }

        public VrelMapping(string schema)
        {
            ToTable("VREL", schema);
            HasKey(x => x.Vrel001);

            Property(x => x.Vrel001).HasColumnName(@"VREL001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Vrel005).HasColumnName(@"VREL005").HasColumnType("int").IsRequired();
            Property(x => x.Vrel010).HasColumnName(@"VREL010").HasColumnType("int").IsRequired();
            Property(x => x.Vrel015).HasColumnName(@"VREL015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Vrel020).HasColumnName(@"VREL020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Vrel025).HasColumnName(@"VREL025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Vrel030).HasColumnName(@"VREL030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Vrel050).HasColumnName(@"VREL050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Vrel100).HasColumnName(@"VREL100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Vrel110).HasColumnName(@"VREL110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Vrel120).HasColumnName(@"VREL120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Vrel150).HasColumnName(@"VREL150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Vrel175).HasColumnName(@"VREL175").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Vrel200).HasColumnName(@"VREL200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Vrel201).HasColumnName(@"VREL201").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Vrel130).HasColumnName(@"VREL130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Vrel210).HasColumnName(@"VREL210").HasColumnType("datetime").IsRequired();
            Property(x => x.Vrel220).HasColumnName(@"VREL220").HasColumnType("datetime").IsRequired();
        }
    }

}
