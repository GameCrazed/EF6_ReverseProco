

namespace Generator
{

    public class DialMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Dial>
    {
        public DialMapping()
            : this("dbo")
        {
        }

        public DialMapping(string schema)
        {
            ToTable("DIAL", schema);
            HasKey(x => new { x.Dial001, x.Dial010 });

            Property(x => x.Dial001).HasColumnName(@"DIAL001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Dial010).HasColumnName(@"DIAL010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
