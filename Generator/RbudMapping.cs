

namespace Generator
{

    public class RbudMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rbud>
    {
        public RbudMapping()
            : this("dbo")
        {
        }

        public RbudMapping(string schema)
        {
            ToTable("RBUD", schema);
            HasKey(x => x.Rbud001);

            Property(x => x.Rbud001).HasColumnName(@"RBUD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rbud010).HasColumnName(@"RBUD010").HasColumnType("datetime").IsRequired();
            Property(x => x.Rbud020).HasColumnName(@"RBUD020").HasColumnType("datetime").IsRequired();
            Property(x => x.Rbud030).HasColumnName(@"RBUD030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Rbud040).HasColumnName(@"RBUD040").HasColumnType("datetime").IsRequired();
        }
    }

}
