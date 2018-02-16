

namespace Generator
{

    public class TaxcMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Taxc>
    {
        public TaxcMapping()
            : this("dbo")
        {
        }

        public TaxcMapping(string schema)
        {
            ToTable("TAXC", schema);
            HasKey(x => x.Taxc999);

            Property(x => x.Taxc010).HasColumnName(@"TAXC010").HasColumnType("int").IsRequired();
            Property(x => x.Taxc020).HasColumnName(@"TAXC020").HasColumnType("datetime").IsRequired();
            Property(x => x.Taxc030).HasColumnName(@"TAXC030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Taxc040).HasColumnName(@"TAXC040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Taxc999).HasColumnName(@"TAXC999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Taxc050).HasColumnName(@"TAXC050").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
