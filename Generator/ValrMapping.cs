

namespace Generator
{

    public class ValrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Valr>
    {
        public ValrMapping()
            : this("dbo")
        {
        }

        public ValrMapping(string schema)
        {
            ToTable("VALR", schema);
            HasKey(x => x.Valr002);

            Property(x => x.Valr001).HasColumnName(@"VALR001").HasColumnType("int").IsRequired();
            Property(x => x.Valr002).HasColumnName(@"VALR002").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valr999).HasColumnName(@"VALR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
