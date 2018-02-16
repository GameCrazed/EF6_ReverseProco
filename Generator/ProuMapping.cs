

namespace Generator
{

    public class ProuMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prou>
    {
        public ProuMapping()
            : this("dbo")
        {
        }

        public ProuMapping(string schema)
        {
            ToTable("PROU", schema);
            HasKey(x => x.Prou001);

            Property(x => x.Prou001).HasColumnName(@"PROU001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prou010).HasColumnName(@"PROU010").HasColumnType("smallint").IsRequired();
            Property(x => x.Prou015).HasColumnName(@"PROU015").HasColumnType("smallint").IsRequired();
            Property(x => x.Prou020).HasColumnName(@"PROU020").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prou025).HasColumnName(@"PROU025").HasColumnType("smallint").IsRequired();
        }
    }

}
