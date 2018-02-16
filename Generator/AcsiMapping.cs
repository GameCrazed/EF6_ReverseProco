

namespace Generator
{

    public class AcsiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acsi>
    {
        public AcsiMapping()
            : this("dbo")
        {
        }

        public AcsiMapping(string schema)
        {
            ToTable("ACSI", schema);
            HasKey(x => x.Acsi001);

            Property(x => x.Acsi001).HasColumnName(@"ACSI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acsi020).HasColumnName(@"ACSI020").HasColumnType("int").IsRequired();
            Property(x => x.Acsi030).HasColumnName(@"ACSI030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acsi040).HasColumnName(@"ACSI040").HasColumnType("datetime").IsRequired();
        }
    }

}
