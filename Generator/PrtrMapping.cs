

namespace Generator
{

    public class PrtrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prtr>
    {
        public PrtrMapping()
            : this("dbo")
        {
        }

        public PrtrMapping(string schema)
        {
            ToTable("PRTR", schema);
            HasKey(x => x.Prtr999);

            Property(x => x.Prtr999).HasColumnName(@"PRTR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prtr000).HasColumnName(@"PRTR000").HasColumnType("int").IsRequired();
            Property(x => x.Prtr010).HasColumnName(@"PRTR010").HasColumnType("int").IsRequired();
            Property(x => x.Prtr020).HasColumnName(@"PRTR020").HasColumnType("smallint").IsRequired();
            Property(x => x.Prtr030).HasColumnName(@"PRTR030").HasColumnType("int").IsRequired();
            Property(x => x.Prtr040).HasColumnName(@"PRTR040").HasColumnType("datetime").IsRequired();
        }
    }

}
