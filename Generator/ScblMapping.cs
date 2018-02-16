

namespace Generator
{

    public class ScblMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Scbl>
    {
        public ScblMapping()
            : this("dbo")
        {
        }

        public ScblMapping(string schema)
        {
            ToTable("SCBL", schema);
            HasKey(x => new { x.Scbl001, x.Scbl005 });

            Property(x => x.Scbl001).HasColumnName(@"SCBL001").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Scbl005).HasColumnName(@"SCBL005").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Scbl010).HasColumnName(@"SCBL010").HasColumnType("smallint").IsRequired();
        }
    }

}
