

namespace Generator
{

    public class ClrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Clr>
    {
        public ClrMapping()
            : this("dbo")
        {
        }

        public ClrMapping(string schema)
        {
            ToTable("CLRS", schema);
            HasKey(x => x.Clrs001);

            Property(x => x.Clrs001).HasColumnName(@"CLRS001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Clrs010).HasColumnName(@"CLRS010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Clrs020).HasColumnName(@"CLRS020").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clrs030).HasColumnName(@"CLRS030").HasColumnType("int").IsRequired();
            Property(x => x.Clrs0401).HasColumnName(@"CLRS0401").HasColumnType("int").IsRequired();
            Property(x => x.Clrs0402).HasColumnName(@"CLRS0402").HasColumnType("int").IsRequired();
            Property(x => x.Clrs0403).HasColumnName(@"CLRS0403").HasColumnType("int").IsRequired();
        }
    }

}
