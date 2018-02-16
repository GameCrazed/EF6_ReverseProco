

namespace Generator
{

    public class RmlvMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rmlv>
    {
        public RmlvMapping()
            : this("dbo")
        {
        }

        public RmlvMapping(string schema)
        {
            ToTable("RMLV", schema);
            HasKey(x => x.Rmlv999);

            Property(x => x.Rmlv001).HasColumnName(@"RMLV001").HasColumnType("int").IsRequired();
            Property(x => x.Rmlv010).HasColumnName(@"RMLV010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Rmlv999).HasColumnName(@"RMLV999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Rmlv080).HasColumnName(@"RMLV080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Rmlv090).HasColumnName(@"RMLV090").HasColumnType("datetime").IsRequired();
        }
    }

}
