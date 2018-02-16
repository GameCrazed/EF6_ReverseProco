

namespace Generator
{

    public class EpinMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Epin>
    {
        public EpinMapping()
            : this("dbo")
        {
        }

        public EpinMapping(string schema)
        {
            ToTable("EPIN", schema);
            HasKey(x => x.Epin000);

            Property(x => x.Epin000).HasColumnName(@"EPIN000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Epin010).HasColumnName(@"EPIN010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
