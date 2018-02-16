

namespace Generator
{

    public class ConfMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Conf>
    {
        public ConfMapping()
            : this("dbo")
        {
        }

        public ConfMapping(string schema)
        {
            ToTable("CONF", schema);
            HasKey(x => x.Conf001);

            Property(x => x.Conf000).HasColumnName(@"CONF000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Conf001).HasColumnName(@"CONF001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Conf005).HasColumnName(@"CONF005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Conf010).HasColumnName(@"CONF010").HasColumnType("tinyint").IsRequired();
            Property(x => x.Conf025).HasColumnName(@"CONF025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Conf031).HasColumnName(@"CONF031").HasColumnType("smallint").IsRequired();
            Property(x => x.Conf033).HasColumnName(@"CONF033").HasColumnType("datetime").IsRequired();
        }
    }

}
