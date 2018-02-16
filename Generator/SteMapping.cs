

namespace Generator
{

    public class SteMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ste>
    {
        public SteMapping()
            : this("dbo")
        {
        }

        public SteMapping(string schema)
        {
            ToTable("STES", schema);
            HasKey(x => x.Stes999);

            Property(x => x.Stes999).HasColumnName(@"STES999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Stes010).HasColumnName(@"STES010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Stes020).HasColumnName(@"STES020").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Stes032).HasColumnName(@"STES032").HasColumnType("datetime").IsRequired();
            Property(x => x.Stes034).HasColumnName(@"STES034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Stes036).HasColumnName(@"STES036").HasColumnType("int").IsRequired();
        }
    }

}
