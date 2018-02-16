

namespace Generator
{

    public class RolpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rolp>
    {
        public RolpMapping()
            : this("dbo")
        {
        }

        public RolpMapping(string schema)
        {
            ToTable("ROLP", schema);
            HasKey(x => x.Rolp010);

            Property(x => x.Rolp001).HasColumnName(@"ROLP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Rolp010).HasColumnName(@"ROLP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rolp020).HasColumnName(@"ROLP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
        }
    }

}
