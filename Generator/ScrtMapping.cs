

namespace Generator
{

    public class ScrtMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Scrt>
    {
        public ScrtMapping()
            : this("dbo")
        {
        }

        public ScrtMapping(string schema)
        {
            ToTable("SCRT", schema);
            HasKey(x => x.Scrt010);

            Property(x => x.Scrt010).HasColumnName(@"SCRT010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Scrt020).HasColumnName(@"SCRT020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Scrt030).HasColumnName(@"SCRT030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Scrt040).HasColumnName(@"SCRT040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Scrt050).HasColumnName(@"SCRT050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Scrt060).HasColumnName(@"SCRT060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Scrt400).HasColumnName(@"SCRT400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Scrt100).HasColumnName(@"SCRT100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt101).HasColumnName(@"SCRT101").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt102).HasColumnName(@"SCRT102").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt103).HasColumnName(@"SCRT103").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt104).HasColumnName(@"SCRT104").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt105).HasColumnName(@"SCRT105").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt106).HasColumnName(@"SCRT106").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt107).HasColumnName(@"SCRT107").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt108).HasColumnName(@"SCRT108").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt109).HasColumnName(@"SCRT109").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt110).HasColumnName(@"SCRT110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt111).HasColumnName(@"SCRT111").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt112).HasColumnName(@"SCRT112").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt113).HasColumnName(@"SCRT113").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt114).HasColumnName(@"SCRT114").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt115).HasColumnName(@"SCRT115").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt116).HasColumnName(@"SCRT116").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt117).HasColumnName(@"SCRT117").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt118).HasColumnName(@"SCRT118").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt119).HasColumnName(@"SCRT119").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt120).HasColumnName(@"SCRT120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt121).HasColumnName(@"SCRT121").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt122).HasColumnName(@"SCRT122").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt123).HasColumnName(@"SCRT123").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt124).HasColumnName(@"SCRT124").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt125).HasColumnName(@"SCRT125").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt126).HasColumnName(@"SCRT126").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt127).HasColumnName(@"SCRT127").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt128).HasColumnName(@"SCRT128").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt129).HasColumnName(@"SCRT129").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt130).HasColumnName(@"SCRT130").HasColumnType("tinyint").IsRequired();
            Property(x => x.Scrt300).HasColumnName(@"SCRT300").HasColumnType("smallint").IsRequired();
        }
    }

}
