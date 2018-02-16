

namespace Generator
{

    public class PheaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Phea>
    {
        public PheaMapping()
            : this("dbo")
        {
        }

        public PheaMapping(string schema)
        {
            ToTable("PHEA", schema);
            HasKey(x => x.Phea001);

            Property(x => x.Phea001).HasColumnName(@"PHEA001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Phea010).HasColumnName(@"PHEA010").HasColumnType("int").IsRequired();
            Property(x => x.Phea020).HasColumnName(@"PHEA020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Phea053).HasColumnName(@"PHEA053").HasColumnType("smallint").IsRequired();
            Property(x => x.Phea055).HasColumnName(@"PHEA055").HasColumnType("int").IsRequired();
            Property(x => x.Phea064).HasColumnName(@"PHEA064").HasColumnType("int").IsRequired();
            Property(x => x.Phea100).HasColumnName(@"PHEA100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Phea105).HasColumnName(@"PHEA105").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea110).HasColumnName(@"PHEA110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea115).HasColumnName(@"PHEA115").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea120).HasColumnName(@"PHEA120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea125).HasColumnName(@"PHEA125").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea130).HasColumnName(@"PHEA130").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea135).HasColumnName(@"PHEA135").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea150).HasColumnName(@"PHEA150").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea155).HasColumnName(@"PHEA155").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phea200).HasColumnName(@"PHEA200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Phea210).HasColumnName(@"PHEA210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phea220).HasColumnName(@"PHEA220").HasColumnType("int").IsRequired();
            Property(x => x.Phea230).HasColumnName(@"PHEA230").HasColumnType("smallint").IsRequired();
            Property(x => x.Phea300).HasColumnName(@"PHEA300").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phea310).HasColumnName(@"PHEA310").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phea320).HasColumnName(@"PHEA320").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Phea330).HasColumnName(@"PHEA330").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Phea340).HasColumnName(@"PHEA340").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Phea350).HasColumnName(@"PHEA350").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Phea390).HasColumnName(@"PHEA390").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phea400).HasColumnName(@"PHEA400").HasColumnType("datetime").IsRequired();
            Property(x => x.Phea410).HasColumnName(@"PHEA410").HasColumnType("smallint").IsRequired();
            Property(x => x.Phea420).HasColumnName(@"PHEA420").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phea240).HasColumnName(@"PHEA240").HasColumnType("datetime").IsRequired();
        }
    }

}
