

namespace Generator
{

    public class KfixMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Kfix>
    {
        public KfixMapping()
            : this("dbo")
        {
        }

        public KfixMapping(string schema)
        {
            ToTable("KFIX", schema);
            HasKey(x => x.Kfix000);

            Property(x => x.Kfix000).HasColumnName(@"KFIX000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kfix010).HasColumnName(@"KFIX010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix020).HasColumnName(@"KFIX020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix030).HasColumnName(@"KFIX030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix040).HasColumnName(@"KFIX040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix050).HasColumnName(@"KFIX050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix060).HasColumnName(@"KFIX060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix080).HasColumnName(@"KFIX080").HasColumnType("smallint").IsRequired();
            Property(x => x.Kfix090).HasColumnName(@"KFIX090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix070).HasColumnName(@"KFIX070").HasColumnType("datetime").IsRequired();
            Property(x => x.Kfix280).HasColumnName(@"KFIX280").HasColumnType("int").IsRequired();
            Property(x => x.Kfix290).HasColumnName(@"KFIX290").HasColumnType("int").IsRequired();
            Property(x => x.Kfix300).HasColumnName(@"KFIX300").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Kfix310).HasColumnName(@"KFIX310").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix320).HasColumnName(@"KFIX320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Kfix340).HasColumnName(@"KFIX340").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Kfix350).HasColumnName(@"KFIX350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Kfix360).HasColumnName(@"KFIX360").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix420).HasColumnName(@"KFIX420").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix900).HasColumnName(@"KFIX900").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfix910).HasColumnName(@"KFIX910").HasColumnType("datetime").IsRequired();
            Property(x => x.Kfix920).HasColumnName(@"KFIX920").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfix930).HasColumnName(@"KFIX930").HasColumnType("datetime").IsRequired();
            Property(x => x.Kfix100).HasColumnName(@"KFIX100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Kfix110).HasColumnName(@"KFIX110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix500).HasColumnName(@"KFIX500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Kfix510).HasColumnName(@"KFIX510").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Kfix120).HasColumnName(@"KFIX120").HasColumnType("int").IsRequired();
            Property(x => x.Kfix530).HasColumnName(@"KFIX530").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Kfix130).HasColumnName(@"KFIX130").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfix140).HasColumnName(@"KFIX140").HasColumnType("int").IsRequired();
            Property(x => x.Kfix520).HasColumnName(@"KFIX520").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Kfix430).HasColumnName(@"KFIX430").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix440).HasColumnName(@"KFIX440").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Kfix501).HasColumnName(@"KFIX501").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Kfix600).HasColumnName(@"KFIX600").HasColumnType("tinyint").IsRequired();
            Property(x => x.Kfix602).HasColumnName(@"KFIX602").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix605).HasColumnName(@"KFIX605").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix610).HasColumnName(@"KFIX610").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix615).HasColumnName(@"KFIX615").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix144).HasColumnName(@"KFIX144").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix141).HasColumnName(@"KFIX141").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Kfix142).HasColumnName(@"KFIX142").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Kfix143).HasColumnName(@"KFIX143").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Kfix616).HasColumnName(@"KFIX616").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix150).HasColumnName(@"KFIX150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix151).HasColumnName(@"KFIX151").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix152).HasColumnName(@"KFIX152").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix153).HasColumnName(@"KFIX153").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix154).HasColumnName(@"KFIX154").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix155).HasColumnName(@"KFIX155").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Kfix011).HasColumnName(@"KFIX011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Kfix618).HasColumnName(@"KFIX618").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(850);
            Property(x => x.Kfix370).HasColumnName(@"KFIX370").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
