

namespace Generator
{

    public class AddrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Addr>
    {
        public AddrMapping()
            : this("dbo")
        {
        }

        public AddrMapping(string schema)
        {
            ToTable("ADDR", schema);
            HasKey(x => x.Addr000);

            Property(x => x.Addr000).HasColumnName(@"ADDR000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Addr001).HasColumnName(@"ADDR001").HasColumnType("int").IsRequired();
            Property(x => x.Addr005).HasColumnName(@"ADDR005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Addr006).HasColumnName(@"ADDR006").HasColumnType("int").IsRequired();
            Property(x => x.Addr011).HasColumnName(@"ADDR011").HasColumnType("datetime").IsRequired();
            Property(x => x.Addr012).HasColumnName(@"ADDR012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Addr0131).HasColumnName(@"ADDR0131").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Addr0132).HasColumnName(@"ADDR0132").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Addr0133).HasColumnName(@"ADDR0133").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Addr0134).HasColumnName(@"ADDR0134").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Addr015).HasColumnName(@"ADDR015").HasColumnType("int").IsRequired();
            Property(x => x.Addr020).HasColumnName(@"ADDR020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Addr025).HasColumnName(@"ADDR025").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Addr031).HasColumnName(@"ADDR031").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Addr032).HasColumnName(@"ADDR032").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Addr033).HasColumnName(@"ADDR033").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Addr034).HasColumnName(@"ADDR034").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Addr035).HasColumnName(@"ADDR035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Addr040).HasColumnName(@"ADDR040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Addrdtm).HasColumnName(@"ADDRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Addr045).HasColumnName(@"ADDR045").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Addr050).HasColumnName(@"ADDR050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Addr061).HasColumnName(@"ADDR061").HasColumnType("datetime").IsRequired();
            Property(x => x.Addr060).HasColumnName(@"ADDR060").HasColumnType("datetime").IsRequired();
        }
    }

}
