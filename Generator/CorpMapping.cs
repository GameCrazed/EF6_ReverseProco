

namespace Generator
{

    public class CorpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Corp>
    {
        public CorpMapping()
            : this("dbo")
        {
        }

        public CorpMapping(string schema)
        {
            ToTable("CORP", schema);
            HasKey(x => x.Corp010);

            Property(x => x.Corp010).HasColumnName(@"CORP010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Corp020).HasColumnName(@"CORP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Corp030).HasColumnName(@"CORP030").HasColumnType("int").IsRequired();
            Property(x => x.Corp040).HasColumnName(@"CORP040").HasColumnType("int").IsRequired();
            Property(x => x.Corp050).HasColumnName(@"CORP050").HasColumnType("smallint").IsRequired();
            Property(x => x.Corp060).HasColumnName(@"CORP060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Corp070).HasColumnName(@"CORP070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Corp080).HasColumnName(@"CORP080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Corp090).HasColumnName(@"CORP090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Corp110).HasColumnName(@"CORP110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Corp120).HasColumnName(@"CORP120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp130).HasColumnName(@"CORP130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp140).HasColumnName(@"CORP140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp180).HasColumnName(@"CORP180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp300).HasColumnName(@"CORP300").HasColumnType("int").IsRequired();
            Property(x => x.Corp015).HasColumnName(@"CORP015").HasColumnType("tinyint").IsRequired();
            Property(x => x.Corp016).HasColumnName(@"CORP016").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp017).HasColumnName(@"CORP017").HasColumnType("datetime").IsRequired();
            Property(x => x.Corp021).HasColumnName(@"CORP021").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp022).HasColumnName(@"CORP022").HasColumnType("int").IsRequired();
            Property(x => x.Corp023).HasColumnName(@"CORP023").HasColumnType("tinyint").IsRequired();
            Property(x => x.Corp024).HasColumnName(@"CORP024").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp026).HasColumnName(@"CORP026").HasColumnType("int").IsRequired();
            Property(x => x.Corp028).HasColumnName(@"CORP028").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Corp0291).HasColumnName(@"CORP0291").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp0292).HasColumnName(@"CORP0292").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp0293).HasColumnName(@"CORP0293").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp0294).HasColumnName(@"CORP0294").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp0295).HasColumnName(@"CORP0295").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp075).HasColumnName(@"CORP075").HasColumnType("smallint").IsRequired();
            Property(x => x.Corp185).HasColumnName(@"CORP185").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp190).HasColumnName(@"CORP190").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp200).HasColumnName(@"CORP200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp210).HasColumnName(@"CORP210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Corp500).HasColumnName(@"CORP500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp510).HasColumnName(@"CORP510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp600).HasColumnName(@"CORP600").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Corp610).HasColumnName(@"CORP610").HasColumnType("int").IsRequired();
            Property(x => x.Corp100).HasColumnName(@"CORP100").HasColumnType("datetime").IsRequired();
            Property(x => x.Corp150).HasColumnName(@"CORP150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Corp055).HasColumnName(@"CORP055").HasColumnType("int").IsRequired();
            Property(x => x.Corp056).HasColumnName(@"CORP056").HasColumnType("datetime").IsRequired();
            Property(x => x.Corp095).HasColumnName(@"CORP095").HasColumnType("datetime").IsRequired();
            Property(x => x.Corp620).HasColumnName(@"CORP620").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(18);
        }
    }

}
