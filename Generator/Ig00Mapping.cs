

namespace Generator
{

    public class Ig00Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ig00>
    {
        public Ig00Mapping()
            : this("dbo")
        {
        }

        public Ig00Mapping(string schema)
        {
            ToTable("IG00", schema);
            HasKey(x => new { x.Ig00001, x.Ig00005 });

            Property(x => x.Ig00001).HasColumnName(@"IG00001").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ig00002).HasColumnName(@"IG00002").HasColumnType("int").IsRequired();
            Property(x => x.Ig00003).HasColumnName(@"IG00003").HasColumnType("int").IsRequired();
            Property(x => x.Ig00004).HasColumnName(@"IG00004").HasColumnType("int").IsRequired();
            Property(x => x.Ig00005).HasColumnName(@"IG00005").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ig00006).HasColumnName(@"IG00006").HasColumnType("int").IsRequired();
            Property(x => x.Ig00008).HasColumnName(@"IG00008").HasColumnType("int").IsRequired();
            Property(x => x.Ig00010).HasColumnName(@"IG00010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Ig00020).HasColumnName(@"IG00020").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ig00Dtm).HasColumnName(@"IG00DTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Ig00050).HasColumnName(@"IG00050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Ig00011).HasColumnName(@"IG00011").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Ig00012).HasColumnName(@"IG00012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
