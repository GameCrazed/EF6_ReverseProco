

namespace Generator
{

    public class SvadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Svad>
    {
        public SvadMapping()
            : this("dbo")
        {
        }

        public SvadMapping(string schema)
        {
            ToTable("SVAD", schema);
            HasKey(x => new { x.Svad005, x.Svad010 });

            Property(x => x.Svad005).HasColumnName(@"SVAD005").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Svad010).HasColumnName(@"SVAD010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Svad015).HasColumnName(@"SVAD015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Svad020).HasColumnName(@"SVAD020").HasColumnType("int").IsRequired();
        }
    }

}
