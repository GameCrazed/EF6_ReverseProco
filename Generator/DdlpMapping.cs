

namespace Generator
{

    public class DdlpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ddlp>
    {
        public DdlpMapping()
            : this("dbo")
        {
        }

        public DdlpMapping(string schema)
        {
            ToTable("DDLP", schema);
            HasKey(x => x.Ddlp000);

            Property(x => x.Ddlp000).HasColumnName(@"DDLP000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ddlp010).HasColumnName(@"DDLP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Ddlp020).HasColumnName(@"DDLP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ddlp030).HasColumnName(@"DDLP030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ddlp040).HasColumnName(@"DDLP040").HasColumnType("int").IsRequired();
            Property(x => x.Ddlp050).HasColumnName(@"DDLP050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ddlp100).HasColumnName(@"DDLP100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ddlp101).HasColumnName(@"DDLP101").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp102).HasColumnName(@"DDLP102").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp103).HasColumnName(@"DDLP103").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp104).HasColumnName(@"DDLP104").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp105).HasColumnName(@"DDLP105").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp106).HasColumnName(@"DDLP106").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp107).HasColumnName(@"DDLP107").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp108).HasColumnName(@"DDLP108").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp109).HasColumnName(@"DDLP109").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp110).HasColumnName(@"DDLP110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp150).HasColumnName(@"DDLP150").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ddlp063).HasColumnName(@"DDLP063").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ddlp065).HasColumnName(@"DDLP065").HasColumnType("tinyint").IsRequired();
        }
    }

}
