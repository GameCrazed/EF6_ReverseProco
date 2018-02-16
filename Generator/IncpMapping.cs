

namespace Generator
{

    public class IncpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Incp>
    {
        public IncpMapping()
            : this("dbo")
        {
        }

        public IncpMapping(string schema)
        {
            ToTable("INCP", schema);
            HasKey(x => x.Incp999);

            Property(x => x.Incp001).HasColumnName(@"INCP001").HasColumnType("int").IsRequired();
            Property(x => x.Incp010).HasColumnName(@"INCP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Incp020).HasColumnName(@"INCP020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Incp030).HasColumnName(@"INCP030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Incp040).HasColumnName(@"INCP040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Incp050).HasColumnName(@"INCP050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Incp060).HasColumnName(@"INCP060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Incp070).HasColumnName(@"INCP070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(16);
            Property(x => x.Incp080).HasColumnName(@"INCP080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Incp090).HasColumnName(@"INCP090").HasColumnType("datetime").IsRequired();
            Property(x => x.Incp100).HasColumnName(@"INCP100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Incp120).HasColumnName(@"INCP120").HasColumnType("int").IsRequired();
            Property(x => x.Incp130).HasColumnName(@"INCP130").HasColumnType("int").IsRequired();
            Property(x => x.Incp999).HasColumnName(@"INCP999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
