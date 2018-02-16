

namespace Generator
{

    public class IlnkMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ilnk>
    {
        public IlnkMapping()
            : this("dbo")
        {
        }

        public IlnkMapping(string schema)
        {
            ToTable("ILNK", schema);
            HasKey(x => new { x.Ilnk001, x.Ilnk002 });

            Property(x => x.Ilnk001).HasColumnName(@"ILNK001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ilnk002).HasColumnName(@"ILNK002").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ilnk005).HasColumnName(@"ILNK005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ilnk010).HasColumnName(@"ILNK010").HasColumnType("datetime").IsRequired();
            Property(x => x.Ilnk020).HasColumnName(@"ILNK020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ilnk030).HasColumnName(@"ILNK030").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
