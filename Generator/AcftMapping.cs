

namespace Generator
{

    public class AcftMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acft>
    {
        public AcftMapping()
            : this("dbo")
        {
        }

        public AcftMapping(string schema)
        {
            ToTable("ACFT", schema);
            HasKey(x => new { x.Acft080, x.Acft090 });

            Property(x => x.Acft010).HasColumnName(@"ACFT010").HasColumnType("datetime").IsRequired();
            Property(x => x.Acft020).HasColumnName(@"ACFT020").HasColumnType("int").IsRequired();
            Property(x => x.Acft030).HasColumnName(@"ACFT030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acft040).HasColumnName(@"ACFT040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acft050).HasColumnName(@"ACFT050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acft060).HasColumnName(@"ACFT060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acft080).HasColumnName(@"ACFT080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acft090).HasColumnName(@"ACFT090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acft100).HasColumnName(@"ACFT100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Acftdtm).HasColumnName(@"ACFTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
