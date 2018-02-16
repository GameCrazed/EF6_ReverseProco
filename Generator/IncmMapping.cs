

namespace Generator
{

    public class IncmMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Incm>
    {
        public IncmMapping()
            : this("dbo")
        {
        }

        public IncmMapping(string schema)
        {
            ToTable("INCM", schema);
            HasKey(x => x.Incm000);

            Property(x => x.Incm000).HasColumnName(@"INCM000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Incm001).HasColumnName(@"INCM001").HasColumnType("int").IsRequired();
            Property(x => x.Incm020).HasColumnName(@"INCM020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Incm030).HasColumnName(@"INCM030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Incm040).HasColumnName(@"INCM040").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Incm050).HasColumnName(@"INCM050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
