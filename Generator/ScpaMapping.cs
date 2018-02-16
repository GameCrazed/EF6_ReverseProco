

namespace Generator
{

    public class ScpaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Scpa>
    {
        public ScpaMapping()
            : this("dbo")
        {
        }

        public ScpaMapping(string schema)
        {
            ToTable("SCPA", schema);
            HasKey(x => x.Scpa001);

            Property(x => x.Scpa001).HasColumnName(@"SCPA001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Scpa010).HasColumnName(@"SCPA010").HasColumnType("smallint").IsRequired();
            Property(x => x.Scpa015).HasColumnName(@"SCPA015").HasColumnType("smallint").IsRequired();
            Property(x => x.Scpa020).HasColumnName(@"SCPA020").HasColumnType("smallint").IsRequired();
            Property(x => x.Scpa025).HasColumnName(@"SCPA025").HasColumnType("smallint").IsRequired();
        }
    }

}
