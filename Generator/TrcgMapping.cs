

namespace Generator
{

    public class TrcgMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Trcg>
    {
        public TrcgMapping()
            : this("dbo")
        {
        }

        public TrcgMapping(string schema)
        {
            ToTable("TRCG", schema);
            HasKey(x => new { x.Trcg001, x.Trcg010 });

            Property(x => x.Trcg001).HasColumnName(@"TRCG001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Trcg010).HasColumnName(@"TRCG010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
