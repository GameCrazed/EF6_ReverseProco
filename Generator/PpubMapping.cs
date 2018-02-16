

namespace Generator
{

    public class PpubMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ppub>
    {
        public PpubMapping()
            : this("dbo")
        {
        }

        public PpubMapping(string schema)
        {
            ToTable("PPUB", schema);
            HasKey(x => x.Ppub001);

            Property(x => x.Ppub001).HasColumnName(@"PPUB001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ppub010).HasColumnName(@"PPUB010").HasColumnType("int").IsRequired();
            Property(x => x.Ppub020).HasColumnName(@"PPUB020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ppub053).HasColumnName(@"PPUB053").HasColumnType("smallint").IsRequired();
            Property(x => x.Ppub055).HasColumnName(@"PPUB055").HasColumnType("int").IsRequired();
            Property(x => x.Ppub064).HasColumnName(@"PPUB064").HasColumnType("int").IsRequired();
            Property(x => x.Ppub100).HasColumnName(@"PPUB100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ppub110).HasColumnName(@"PPUB110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Ppub120).HasColumnName(@"PPUB120").HasColumnType("int").IsRequired();
            Property(x => x.Ppub130).HasColumnName(@"PPUB130").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Ppub200).HasColumnName(@"PPUB200").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ppub210).HasColumnName(@"PPUB210").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ppub220).HasColumnName(@"PPUB220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ppub300).HasColumnName(@"PPUB300").HasColumnType("smallint").IsRequired();
            Property(x => x.Ppub310).HasColumnName(@"PPUB310").HasColumnType("smallint").IsRequired();
            Property(x => x.Ppub320).HasColumnName(@"PPUB320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ppub330).HasColumnName(@"PPUB330").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Ppub340).HasColumnName(@"PPUB340").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ppub350).HasColumnName(@"PPUB350").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Ppub390).HasColumnName(@"PPUB390").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Ppub140).HasColumnName(@"PPUB140").HasColumnType("datetime").IsRequired();
        }
    }

}
