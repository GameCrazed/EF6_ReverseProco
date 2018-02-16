

namespace Generator
{

    public class EtrgMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Etrg>
    {
        public EtrgMapping()
            : this("dbo")
        {
        }

        public EtrgMapping(string schema)
        {
            ToTable("ETRG", schema);
            HasKey(x => x.Etrg999);

            Property(x => x.Etrg999).HasColumnName(@"ETRG999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Etrg001).HasColumnName(@"ETRG001").HasColumnType("int").IsRequired();
            Property(x => x.Etrg010).HasColumnName(@"ETRG010").HasColumnType("int").IsRequired();
            Property(x => x.Etrg020).HasColumnName(@"ETRG020").HasColumnType("tinyint").IsRequired();
        }
    }

}
