

namespace Generator
{

    public class PrcdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prcd>
    {
        public PrcdMapping()
            : this("dbo")
        {
        }

        public PrcdMapping(string schema)
        {
            ToTable("PRCD", schema);
            HasKey(x => new { x.Prcd010, x.Prcd015 });

            Property(x => x.Prcd010).HasColumnName(@"PRCD010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prcd015).HasColumnName(@"PRCD015").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prcd020).HasColumnName(@"PRCD020").HasColumnType("datetime").IsRequired();
            Property(x => x.Prcd030).HasColumnName(@"PRCD030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prcd040).HasColumnName(@"PRCD040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prcd050).HasColumnName(@"PRCD050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prcd060).HasColumnName(@"PRCD060").HasColumnType("datetime").IsRequired();
            Property(x => x.Prcd070).HasColumnName(@"PRCD070").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
