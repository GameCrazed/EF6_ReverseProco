

namespace Generator
{

    public class PrapMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prap>
    {
        public PrapMapping()
            : this("dbo")
        {
        }

        public PrapMapping(string schema)
        {
            ToTable("PRAP", schema);
            HasKey(x => x.Prap010);

            Property(x => x.Prap010).HasColumnName(@"PRAP010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prap015).HasColumnName(@"PRAP015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prap020).HasColumnName(@"PRAP020").HasColumnType("int").IsRequired();
            Property(x => x.Prap025).HasColumnName(@"PRAP025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prap030).HasColumnName(@"PRAP030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap035).HasColumnName(@"PRAP035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prap040).HasColumnName(@"PRAP040").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap050).HasColumnName(@"PRAP050").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap090).HasColumnName(@"PRAP090").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap095).HasColumnName(@"PRAP095").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prap100).HasColumnName(@"PRAP100").HasColumnType("int").IsRequired();
            Property(x => x.Prap105).HasColumnName(@"PRAP105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Prap110).HasColumnName(@"PRAP110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Prap115).HasColumnName(@"PRAP115").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap120).HasColumnName(@"PRAP120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap125).HasColumnName(@"PRAP125").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap190).HasColumnName(@"PRAP190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap200).HasColumnName(@"PRAP200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prap201).HasColumnName(@"PRAP201").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Prap202).HasColumnName(@"PRAP202").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Prap203).HasColumnName(@"PRAP203").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Prap204).HasColumnName(@"PRAP204").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Prap205).HasColumnName(@"PRAP205").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Prap208).HasColumnName(@"PRAP208").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prap210).HasColumnName(@"PRAP210").HasColumnType("int").IsRequired();
            Property(x => x.Prap212).HasColumnName(@"PRAP212").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap213).HasColumnName(@"PRAP213").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap214).HasColumnName(@"PRAP214").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap215).HasColumnName(@"PRAP215").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prap216).HasColumnName(@"PRAP216").HasColumnType("int").IsRequired();
            Property(x => x.Prap217).HasColumnName(@"PRAP217").HasColumnType("int").IsRequired();
            Property(x => x.Prap218).HasColumnName(@"PRAP218").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap219).HasColumnName(@"PRAP219").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prap220).HasColumnName(@"PRAP220").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap225).HasColumnName(@"PRAP225").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap230).HasColumnName(@"PRAP230").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap235).HasColumnName(@"PRAP235").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap250).HasColumnName(@"PRAP250").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap255).HasColumnName(@"PRAP255").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap260).HasColumnName(@"PRAP260").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap265).HasColumnName(@"PRAP265").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap290).HasColumnName(@"PRAP290").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap312).HasColumnName(@"PRAP312").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap313).HasColumnName(@"PRAP313").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap314).HasColumnName(@"PRAP314").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap316).HasColumnName(@"PRAP316").HasColumnType("int").IsRequired();
            Property(x => x.Prap330).HasColumnName(@"PRAP330").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap335).HasColumnName(@"PRAP335").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap350).HasColumnName(@"PRAP350").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap355).HasColumnName(@"PRAP355").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap360).HasColumnName(@"PRAP360").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap365).HasColumnName(@"PRAP365").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap390).HasColumnName(@"PRAP390").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap500).HasColumnName(@"PRAP500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Prap505).HasColumnName(@"PRAP505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap510).HasColumnName(@"PRAP510").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prap520).HasColumnName(@"PRAP520").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap525).HasColumnName(@"PRAP525").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap620).HasColumnName(@"PRAP620").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prap700).HasColumnName(@"PRAP700").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prap7051).HasColumnName(@"PRAP7051").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap7052).HasColumnName(@"PRAP7052").HasColumnType("smallint").IsRequired();
            Property(x => x.Prap710).HasColumnName(@"PRAP710").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Prap715).HasColumnName(@"PRAP715").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Prap720).HasColumnName(@"PRAP720").HasColumnType("int").IsRequired();
            Property(x => x.Prap725).HasColumnName(@"PRAP725").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Prap112).HasColumnName(@"PRAP112").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Prap209).HasColumnName(@"PRAP209").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prap211).HasColumnName(@"PRAP211").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap228).HasColumnName(@"PRAP228").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap712).HasColumnName(@"PRAP712").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Prap516).HasColumnName(@"PRAP516").HasColumnType("int").IsRequired();
            Property(x => x.Prap556).HasColumnName(@"PRAP556").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prap730).HasColumnName(@"PRAP730").HasColumnType("int").IsRequired();
            Property(x => x.Prap721).HasColumnName(@"PRAP721").HasColumnType("int").IsRequired();
            Property(x => x.Prap012).HasColumnName(@"PRAP012").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prap080).HasColumnName(@"PRAP080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prap085).HasColumnName(@"PRAP085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prap280).HasColumnName(@"PRAP280").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap380).HasColumnName(@"PRAP380").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap722).HasColumnName(@"PRAP722").HasColumnType("int").IsRequired();
            Property(x => x.Prap127).HasColumnName(@"PRAP127").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Prap735).HasColumnName(@"PRAP735").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prap713).HasColumnName(@"PRAP713").HasColumnType("int").IsRequired();
            Property(x => x.Prap800).HasColumnName(@"PRAP800").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap001).HasColumnName(@"PRAP001").HasColumnType("int").IsRequired();
            Property(x => x.Prap046).HasColumnName(@"PRAP046").HasColumnType("int").IsRequired();
            Property(x => x.Prap021).HasColumnName(@"PRAP021").HasColumnType("int").IsRequired();
            Property(x => x.Prap026).HasColumnName(@"PRAP026").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Prap031).HasColumnName(@"PRAP031").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Prap081).HasColumnName(@"PRAP081").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Prap082).HasColumnName(@"PRAP082").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Prap660).HasColumnName(@"PRAP660").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap661).HasColumnName(@"PRAP661").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prap662).HasColumnName(@"PRAP662").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap663).HasColumnName(@"PRAP663").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prap664).HasColumnName(@"PRAP664").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prap666).HasColumnName(@"PRAP666").HasColumnType("datetime").IsRequired();
            Property(x => x.Prap087).HasColumnName(@"PRAP087").HasColumnType("int").IsRequired();
            Property(x => x.Prap810).HasColumnName(@"PRAP810").HasColumnType("int").IsRequired();
            Property(x => x.Prap820).HasColumnName(@"PRAP820").HasColumnType("datetime").IsRequired();
        }
    }

}
