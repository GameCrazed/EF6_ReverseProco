

namespace Generator
{

    public class DdtlMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ddtl>
    {
        public DdtlMapping()
            : this("dbo")
        {
        }

        public DdtlMapping(string schema)
        {
            ToTable("DDTL", schema);
            HasKey(x => x.Ddtl000);

            Property(x => x.Ddtl000).HasColumnName(@"DDTL000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ddtl005).HasColumnName(@"DDTL005").HasColumnType("int").IsRequired();
            Property(x => x.Ddtl010).HasColumnName(@"DDTL010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Ddtl015).HasColumnName(@"DDTL015").HasColumnType("datetime").IsRequired();
            Property(x => x.Ddtl020).HasColumnName(@"DDTL020").HasColumnType("datetime").IsRequired();
            Property(x => x.Ddtl025).HasColumnName(@"DDTL025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ddtl030).HasColumnName(@"DDTL030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Ddtl035).HasColumnName(@"DDTL035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ddtl040).HasColumnName(@"DDTL040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Ddtl045).HasColumnName(@"DDTL045").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ddtl050).HasColumnName(@"DDTL050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ddtl055).HasColumnName(@"DDTL055").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ddtl060).HasColumnName(@"DDTL060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Ddtl065).HasColumnName(@"DDTL065").HasColumnType("int").IsRequired();
            Property(x => x.Ddtl070).HasColumnName(@"DDTL070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ddtl075).HasColumnName(@"DDTL075").HasColumnType("int").IsRequired();
            Property(x => x.Ddtldtm).HasColumnName(@"DDTLDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
