

namespace Generator
{

    public class ValpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Valp>
    {
        public ValpMapping()
            : this("dbo")
        {
        }

        public ValpMapping(string schema)
        {
            ToTable("VALP", schema);
            HasKey(x => x.Valp002);

            Property(x => x.Valp001).HasColumnName(@"VALP001").HasColumnType("int").IsRequired();
            Property(x => x.Valp002).HasColumnName(@"VALP002").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valp999).HasColumnName(@"VALP999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
