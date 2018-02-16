

namespace Generator
{

    public class PednMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pedn>
    {
        public PednMapping()
            : this("dbo")
        {
        }

        public PednMapping(string schema)
        {
            ToTable("PEDN", schema);
            HasKey(x => x.Pedn001);

            Property(x => x.Pedn001).HasColumnName(@"PEDN001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pedn010).HasColumnName(@"PEDN010").HasColumnType("int").IsRequired();
            Property(x => x.Pedn020).HasColumnName(@"PEDN020").HasColumnType("int").IsRequired();
            Property(x => x.Pedn030).HasColumnName(@"PEDN030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
