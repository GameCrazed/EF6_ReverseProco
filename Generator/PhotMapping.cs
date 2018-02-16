

namespace Generator
{

    public class PhotMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Phot>
    {
        public PhotMapping()
            : this("dbo")
        {
        }

        public PhotMapping(string schema)
        {
            ToTable("PHOT", schema);
            HasKey(x => x.Phot001);

            Property(x => x.Phot001).HasColumnName(@"PHOT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Phot010).HasColumnName(@"PHOT010").HasColumnType("int").IsRequired();
            Property(x => x.Phot020).HasColumnName(@"PHOT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Phot053).HasColumnName(@"PHOT053").HasColumnType("smallint").IsRequired();
            Property(x => x.Phot055).HasColumnName(@"PHOT055").HasColumnType("int").IsRequired();
            Property(x => x.Phot064).HasColumnName(@"PHOT064").HasColumnType("int").IsRequired();
            Property(x => x.Phot105).HasColumnName(@"PHOT105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Phot110).HasColumnName(@"PHOT110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot115).HasColumnName(@"PHOT115").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot120).HasColumnName(@"PHOT120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot125).HasColumnName(@"PHOT125").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot130).HasColumnName(@"PHOT130").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot135).HasColumnName(@"PHOT135").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot200).HasColumnName(@"PHOT200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Phot210).HasColumnName(@"PHOT210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phot220).HasColumnName(@"PHOT220").HasColumnType("int").IsRequired();
            Property(x => x.Phot230).HasColumnName(@"PHOT230").HasColumnType("smallint").IsRequired();
            Property(x => x.Phot300).HasColumnName(@"PHOT300").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot305).HasColumnName(@"PHOT305").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phot310).HasColumnName(@"PHOT310").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot315).HasColumnName(@"PHOT315").HasColumnType("int").IsRequired();
            Property(x => x.Phot320).HasColumnName(@"PHOT320").HasColumnType("smallint").IsRequired();
            Property(x => x.Phot325).HasColumnName(@"PHOT325").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phot330).HasColumnName(@"PHOT330").HasColumnType("smallint").IsRequired();
            Property(x => x.Phot335).HasColumnName(@"PHOT335").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Phot340).HasColumnName(@"PHOT340").HasColumnType("smallint").IsRequired();
            Property(x => x.Phot345).HasColumnName(@"PHOT345").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Phot350).HasColumnName(@"PHOT350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Phot355).HasColumnName(@"PHOT355").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phot360).HasColumnName(@"PHOT360").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Phot365).HasColumnName(@"PHOT365").HasColumnType("smallint").IsRequired();
            Property(x => x.Phot390).HasColumnName(@"PHOT390").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Phot240).HasColumnName(@"PHOT240").HasColumnType("datetime").IsRequired();
        }
    }

}
