

namespace Generator
{

    public class TaxrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Taxr>
    {
        public TaxrMapping()
            : this("dbo")
        {
        }

        public TaxrMapping(string schema)
        {
            ToTable("TAXR", schema);
            HasKey(x => new { x.Taxr020, x.Taxr030 });

            Property(x => x.Taxr020).HasColumnName(@"TAXR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Taxr030).HasColumnName(@"TAXR030").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Taxr040).HasColumnName(@"TAXR040").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Taxr050).HasColumnName(@"TAXR050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Taxr0601).HasColumnName(@"TAXR0601").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Taxr0602).HasColumnName(@"TAXR0602").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Taxr0603).HasColumnName(@"TAXR0603").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Taxr0701).HasColumnName(@"TAXR0701").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Taxr0702).HasColumnName(@"TAXR0702").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Taxr0703).HasColumnName(@"TAXR0703").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Taxr080).HasColumnName(@"TAXR080").HasColumnType("datetime").IsRequired();
            Property(x => x.Taxr090).HasColumnName(@"TAXR090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Taxr100).HasColumnName(@"TAXR100").HasColumnType("datetime").IsRequired();
            Property(x => x.Taxr110).HasColumnName(@"TAXR110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Taxrdtm).HasColumnName(@"TAXRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
