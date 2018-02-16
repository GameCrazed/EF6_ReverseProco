

namespace Generator
{

    public class AcctMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acct>
    {
        public AcctMapping()
            : this("dbo")
        {
        }

        public AcctMapping(string schema)
        {
            ToTable("ACCT", schema);
            HasKey(x => x.Acct001);

            Property(x => x.Acct001).HasColumnName(@"ACCT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acct002).HasColumnName(@"ACCT002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Acct003).HasColumnName(@"ACCT003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Acct004).HasColumnName(@"ACCT004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Acct010).HasColumnName(@"ACCT010").HasColumnType("int").IsRequired();
            Property(x => x.Acct011).HasColumnName(@"ACCT011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct012).HasColumnName(@"ACCT012").HasColumnType("int").IsRequired();
            Property(x => x.Acct013).HasColumnName(@"ACCT013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Acct014).HasColumnName(@"ACCT014").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Acct016).HasColumnName(@"ACCT016").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acct018).HasColumnName(@"ACCT018").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acct020).HasColumnName(@"ACCT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Acct022).HasColumnName(@"ACCT022").HasColumnType("int").IsRequired();
            Property(x => x.Acct029).HasColumnName(@"ACCT029").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct030).HasColumnName(@"ACCT030").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct032).HasColumnName(@"ACCT032").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct034).HasColumnName(@"ACCT034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acct052).HasColumnName(@"ACCT052").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct054).HasColumnName(@"ACCT054").HasColumnType("int").IsRequired();
            Property(x => x.Acct056).HasColumnName(@"ACCT056").HasColumnType("int").IsRequired();
            Property(x => x.Acct1021).HasColumnName(@"ACCT1021").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct1022).HasColumnName(@"ACCT1022").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct1023).HasColumnName(@"ACCT1023").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct1024).HasColumnName(@"ACCT1024").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct1025).HasColumnName(@"ACCT1025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct1026).HasColumnName(@"ACCT1026").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct1027).HasColumnName(@"ACCT1027").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct1028).HasColumnName(@"ACCT1028").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct1029).HasColumnName(@"ACCT1029").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct10210).HasColumnName(@"ACCT10210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct10211).HasColumnName(@"ACCT10211").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct10212).HasColumnName(@"ACCT10212").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct152).HasColumnName(@"ACCT152").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct156).HasColumnName(@"ACCT156").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct160).HasColumnName(@"ACCT160").HasColumnType("smallint").IsRequired();
            Property(x => x.Acct161).HasColumnName(@"ACCT161").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct162).HasColumnName(@"ACCT162").HasColumnType("smallint").IsRequired();
            Property(x => x.Acct163).HasColumnName(@"ACCT163").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct168).HasColumnName(@"ACCT168").HasColumnType("int").IsRequired();
            Property(x => x.Acct170).HasColumnName(@"ACCT170").HasColumnType("int").IsRequired();
            Property(x => x.Acct2001).HasColumnName(@"ACCT2001").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct2002).HasColumnName(@"ACCT2002").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct2003).HasColumnName(@"ACCT2003").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct2004).HasColumnName(@"ACCT2004").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct2005).HasColumnName(@"ACCT2005").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct2006).HasColumnName(@"ACCT2006").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct2007).HasColumnName(@"ACCT2007").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct250).HasColumnName(@"ACCT250").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct255).HasColumnName(@"ACCT255").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct256).HasColumnName(@"ACCT256").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Acct260).HasColumnName(@"ACCT260").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acct262).HasColumnName(@"ACCT262").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct300).HasColumnName(@"ACCT300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Acct303).HasColumnName(@"ACCT303").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Acct304).HasColumnName(@"ACCT304").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Acct306).HasColumnName(@"ACCT306").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Acct309).HasColumnName(@"ACCT309").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct310).HasColumnName(@"ACCT310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Acct312).HasColumnName(@"ACCT312").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct402).HasColumnName(@"ACCT402").HasColumnType("int").IsRequired();
            Property(x => x.Acct408).HasColumnName(@"ACCT408").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct412).HasColumnName(@"ACCT412").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct426).HasColumnName(@"ACCT426").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct428).HasColumnName(@"ACCT428").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct430).HasColumnName(@"ACCT430").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct432).HasColumnName(@"ACCT432").HasColumnType("int").IsRequired();
            Property(x => x.Acct502).HasColumnName(@"ACCT502").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Acct504).HasColumnName(@"ACCT504").HasColumnType("int").IsRequired();
            Property(x => x.Acct505).HasColumnName(@"ACCT505").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acct506).HasColumnName(@"ACCT506").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct507).HasColumnName(@"ACCT507").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct508).HasColumnName(@"ACCT508").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct510).HasColumnName(@"ACCT510").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct512).HasColumnName(@"ACCT512").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct514).HasColumnName(@"ACCT514").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct515).HasColumnName(@"ACCT515").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct516).HasColumnName(@"ACCT516").HasColumnType("smallint").IsRequired();
            Property(x => x.Acct556).HasColumnName(@"ACCT556").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct557).HasColumnName(@"ACCT557").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct560).HasColumnName(@"ACCT560").HasColumnType("int").IsRequired();
            Property(x => x.Acct650).HasColumnName(@"ACCT650").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Acct652).HasColumnName(@"ACCT652").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Acct654).HasColumnName(@"ACCT654").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct656).HasColumnName(@"ACCT656").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct658).HasColumnName(@"ACCT658").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct660).HasColumnName(@"ACCT660").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct662).HasColumnName(@"ACCT662").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct664).HasColumnName(@"ACCT664").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct665).HasColumnName(@"ACCT665").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct666).HasColumnName(@"ACCT666").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct668).HasColumnName(@"ACCT668").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct670).HasColumnName(@"ACCT670").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct698).HasColumnName(@"ACCT698").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct700).HasColumnName(@"ACCT700").HasColumnType("int").IsRequired();
            Property(x => x.Acct702).HasColumnName(@"ACCT702").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct704).HasColumnName(@"ACCT704").HasColumnType("int").IsRequired();
            Property(x => x.Acct706).HasColumnName(@"ACCT706").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct708).HasColumnName(@"ACCT708").HasColumnType("int").IsRequired();
            Property(x => x.Acct709).HasColumnName(@"ACCT709").HasColumnType("int").IsRequired();
            Property(x => x.Acct710).HasColumnName(@"ACCT710").HasColumnType("int").IsRequired();
            Property(x => x.Acct711).HasColumnName(@"ACCT711").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct716).HasColumnName(@"ACCT716").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct720).HasColumnName(@"ACCT720").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acct752).HasColumnName(@"ACCT752").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct754).HasColumnName(@"ACCT754").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct756).HasColumnName(@"ACCT756").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct758).HasColumnName(@"ACCT758").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct760).HasColumnName(@"ACCT760").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct762).HasColumnName(@"ACCT762").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct804).HasColumnName(@"ACCT804").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct806).HasColumnName(@"ACCT806").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct808).HasColumnName(@"ACCT808").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct810).HasColumnName(@"ACCT810").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct812).HasColumnName(@"ACCT812").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct814).HasColumnName(@"ACCT814").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct816).HasColumnName(@"ACCT816").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct818).HasColumnName(@"ACCT818").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct058).HasColumnName(@"acct058").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acctdtm).HasColumnName(@"ACCTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Acct730).HasColumnName(@"ACCT730").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acct732).HasColumnName(@"ACCT732").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acct734).HasColumnName(@"ACCT734").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Acct290).HasColumnName(@"ACCT290").HasColumnType("int").IsRequired();
            Property(x => x.Acct570).HasColumnName(@"ACCT570").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct559).HasColumnName(@"ACCT559").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct840).HasColumnName(@"ACCT840").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct845).HasColumnName(@"ACCT845").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct320).HasColumnName(@"ACCT320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct321).HasColumnName(@"ACCT321").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acct517).HasColumnName(@"ACCT517").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct667).HasColumnName(@"ACCT667").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct313).HasColumnName(@"ACCT313").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct681).HasColumnName(@"ACCT681").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct040).HasColumnName(@"ACCT040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acct280).HasColumnName(@"ACCT280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct992).HasColumnName(@"ACCT992").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acct735).HasColumnName(@"ACCT735").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct736).HasColumnName(@"ACCT736").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct050).HasColumnName(@"ACCT050").HasColumnType("smallint").IsRequired();
            Property(x => x.Acct433).HasColumnName(@"ACCT433").HasColumnType("int").IsRequired();
            Property(x => x.Acct561).HasColumnName(@"ACCT561").HasColumnType("smallint").IsRequired();
            Property(x => x.Acct055).HasColumnName(@"ACCT055").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct554).HasColumnName(@"ACCT554").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acct555).HasColumnName(@"ACCT555").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct553).HasColumnName(@"ACCT553").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct509).HasColumnName(@"ACCT509").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acct521).HasColumnName(@"ACCT521").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acct047).HasColumnName(@"ACCT047").HasColumnType("int").IsRequired();
            Property(x => x.Acct113).HasColumnName(@"ACCT113").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct562).HasColumnName(@"ACCT562").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct332).HasColumnName(@"ACCT332").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct333).HasColumnName(@"ACCT333").HasColumnType("datetime").IsRequired();
            Property(x => x.Acct503).HasColumnName(@"ACCT503").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Acct501).HasColumnName(@"ACCT501").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Acct340).HasColumnName(@"ACCT340").HasColumnType("int").IsRequired();
            Property(x => x.Acct606).HasColumnName(@"ACCT606").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acct009).HasColumnName(@"ACCT009").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(16);
            Property(x => x.Acct042).HasColumnName(@"ACCT042").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Acct563).HasColumnName(@"ACCT563").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acct900).HasColumnName(@"ACCT900").HasColumnType("int").IsRequired();
        }
    }

}
