

namespace Generator
{

    public class QuerMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Quer>
    {
        public QuerMapping()
            : this("dbo")
        {
        }

        public QuerMapping(string schema)
        {
            ToTable("QUER", schema);
            HasKey(x => x.Quer001);

            Property(x => x.Quer001).HasColumnName(@"QUER001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Quer010).HasColumnName(@"QUER010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Quer020).HasColumnName(@"QUER020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
        }
    }

}
