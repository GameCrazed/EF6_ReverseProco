

namespace Generator
{

    public class RiskMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Risk>
    {
        public RiskMapping()
            : this("dbo")
        {
        }

        public RiskMapping(string schema)
        {
            ToTable("RISK", schema);
            HasKey(x => x.Risk001);

            Property(x => x.Risk001).HasColumnName(@"RISK001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Risk450).HasColumnName(@"RISK450").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Risk500).HasColumnName(@"RISK500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Riskdtm).HasColumnName(@"RISKDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
