

namespace Generator
{

    public class PaylMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Payl>
    {
        public PaylMapping()
            : this("dbo")
        {
        }

        public PaylMapping(string schema)
        {
            ToTable("PAYL", schema);
            HasKey(x => x.Payl001);

            Property(x => x.Payl001).HasColumnName(@"PAYL001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Payl020).HasColumnName(@"PAYL020").HasColumnType("int").IsRequired();
            Property(x => x.Payl030).HasColumnName(@"PAYL030").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Payldtm).HasColumnName(@"PAYLDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
