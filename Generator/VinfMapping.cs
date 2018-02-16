

namespace Generator
{

    public class VinfMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vinf>
    {
        public VinfMapping()
            : this("dbo")
        {
        }

        public VinfMapping(string schema)
        {
            ToTable("VINF", schema);
            HasKey(x => x.Vinf001);

            Property(x => x.Vinf001).HasColumnName(@"VINF001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Vinf005).HasColumnName(@"VINF005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Vinf010).HasColumnName(@"VINF010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Vinf015).HasColumnName(@"VINF015").HasColumnType("datetime").IsRequired();
            Property(x => x.Vinf020).HasColumnName(@"VINF020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Vinf120).HasColumnName(@"VINF120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Vinf200).HasColumnName(@"VINF200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Vinf250).HasColumnName(@"VINF250").HasColumnType("datetime").IsRequired();
            Property(x => x.Vinf300).HasColumnName(@"VINF300").HasColumnType("int").IsRequired();
            Property(x => x.Vinf310).HasColumnName(@"VINF310").HasColumnType("datetime").IsRequired();
            Property(x => x.Vinf320).HasColumnName(@"VINF320").HasColumnType("datetime").IsRequired();
            Property(x => x.Vinf400).HasColumnName(@"VINF400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Vinf410).HasColumnName(@"VINF410").HasColumnType("int").IsRequired();
            Property(x => x.Vinf420).HasColumnName(@"VINF420").HasColumnType("int").IsRequired();
            Property(x => x.Vinf500).HasColumnName(@"VINF500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Vinf550).HasColumnName(@"VINF550").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Vinf110).HasColumnName(@"VINF110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Vinf560).HasColumnName(@"VINF560").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Vinf570).HasColumnName(@"VINF570").HasColumnType("datetime").IsRequired();
        }
    }

}
