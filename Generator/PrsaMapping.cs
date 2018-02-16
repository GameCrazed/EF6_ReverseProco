

namespace Generator
{

    public class PrsaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Prsa>
    {
        public PrsaMapping()
            : this("dbo")
        {
        }

        public PrsaMapping(string schema)
        {
            ToTable("PRSA", schema);
            HasKey(x => x.Prsa010);

            Property(x => x.Prsa004).HasColumnName(@"PRSA004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Prsa010).HasColumnName(@"PRSA010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Prsa020).HasColumnName(@"PRSA020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Prsa032).HasColumnName(@"PRSA032").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsa035).HasColumnName(@"PRSA035").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa040).HasColumnName(@"PRSA040").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa045).HasColumnName(@"PRSA045").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Prsa049).HasColumnName(@"PRSA049").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa054).HasColumnName(@"PRSA054").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa056).HasColumnName(@"PRSA056").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa058).HasColumnName(@"PRSA058").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa059).HasColumnName(@"PRSA059").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa061).HasColumnName(@"PRSA061").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa062).HasColumnName(@"PRSA062").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa064).HasColumnName(@"PRSA064").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa065).HasColumnName(@"PRSA065").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa066).HasColumnName(@"PRSA066").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa067).HasColumnName(@"PRSA067").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa069).HasColumnName(@"PRSA069").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa071).HasColumnName(@"PRSA071").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Prsa072).HasColumnName(@"PRSA072").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Prsa073).HasColumnName(@"PRSA073").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa074).HasColumnName(@"PRSA074").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa075).HasColumnName(@"PRSA075").HasColumnType("int").IsRequired();
            Property(x => x.Prsa076).HasColumnName(@"PRSA076").HasColumnType("int").IsRequired();
            Property(x => x.Prsa077).HasColumnName(@"PRSA077").HasColumnType("int").IsRequired();
            Property(x => x.Prsa078).HasColumnName(@"PRSA078").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsa079).HasColumnName(@"PRSA079").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsa080).HasColumnName(@"PRSA080").HasColumnType("int").IsRequired();
            Property(x => x.Prsa085).HasColumnName(@"PRSA085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa122).HasColumnName(@"PRSA122").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa124).HasColumnName(@"PRSA124").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa128).HasColumnName(@"PRSA128").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa129).HasColumnName(@"PRSA129").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa131).HasColumnName(@"PRSA131").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa132).HasColumnName(@"PRSA132").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa133).HasColumnName(@"PRSA133").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa136).HasColumnName(@"PRSA136").HasColumnType("int").IsRequired();
            Property(x => x.Prsa165).HasColumnName(@"PRSA165").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa170).HasColumnName(@"PRSA170").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Prsa175).HasColumnName(@"PRSA175").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa176).HasColumnName(@"PRSA176").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Prsa265).HasColumnName(@"PRSA265").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa270).HasColumnName(@"PRSA270").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa280).HasColumnName(@"PRSA280").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa290).HasColumnName(@"PRSA290").HasColumnType("int").IsRequired();
            Property(x => x.Prsa295).HasColumnName(@"PRSA295").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa305).HasColumnName(@"PRSA305").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa310).HasColumnName(@"PRSA310").HasColumnType("int").IsRequired();
            Property(x => x.Prsa315).HasColumnName(@"PRSA315").HasColumnType("int").IsRequired();
            Property(x => x.Prsa320).HasColumnName(@"PRSA320").HasColumnType("int").IsRequired();
            Property(x => x.Prsa325).HasColumnName(@"PRSA325").HasColumnType("int").IsRequired();
            Property(x => x.Prsa481).HasColumnName(@"PRSA481").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa482).HasColumnName(@"PRSA482").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa483).HasColumnName(@"PRSA483").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa485).HasColumnName(@"PRSA485").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa490).HasColumnName(@"PRSA490").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa510).HasColumnName(@"PRSA510").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa570).HasColumnName(@"PRSA570").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa575).HasColumnName(@"PRSA575").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa600).HasColumnName(@"PRSA600").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Prsa650).HasColumnName(@"PRSA650").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa655).HasColumnName(@"PRSA655").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa660).HasColumnName(@"PRSA660").HasColumnType("int").IsRequired();
            Property(x => x.Prsa665).HasColumnName(@"PRSA665").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa670).HasColumnName(@"PRSA670").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa675).HasColumnName(@"PRSA675").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Prsa680).HasColumnName(@"PRSA680").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa685).HasColumnName(@"PRSA685").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa690).HasColumnName(@"PRSA690").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Prsa700).HasColumnName(@"PRSA700").HasColumnType("int").IsRequired();
            Property(x => x.Prsa705).HasColumnName(@"PRSA705").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa710).HasColumnName(@"PRSA710").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa715).HasColumnName(@"PRSA715").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa720).HasColumnName(@"PRSA720").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa725).HasColumnName(@"PRSA725").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa123).HasColumnName(@"PRSA123").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa063).HasColumnName(@"PRSA063").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Prsa550).HasColumnName(@"PRSA550").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa555).HasColumnName(@"PRSA555").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa557).HasColumnName(@"PRSA557").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa330).HasColumnName(@"PRSA330").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa340).HasColumnName(@"PRSA340").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa350).HasColumnName(@"PRSA350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa360).HasColumnName(@"PRSA360").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa370).HasColumnName(@"PRSA370").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa380).HasColumnName(@"PRSA380").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Prsa930).HasColumnName(@"PRSA930").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa940).HasColumnName(@"PRSA940").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsa950).HasColumnName(@"PRSA950").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Prsa990).HasColumnName(@"PRSA990").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsa995).HasColumnName(@"PRSA995").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa970).HasColumnName(@"PRSA970").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa975).HasColumnName(@"PRSA975").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa960).HasColumnName(@"PRSA960").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa965).HasColumnName(@"PRSA965").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa204).HasColumnName(@"PRSA204").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa205).HasColumnName(@"PRSA205").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa206).HasColumnName(@"PRSA206").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa207).HasColumnName(@"PRSA207").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa209).HasColumnName(@"PRSA209").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa212).HasColumnName(@"PRSA212").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa216).HasColumnName(@"PRSA216").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa217).HasColumnName(@"PRSA217").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa231).HasColumnName(@"PRSA231").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa232).HasColumnName(@"PRSA232").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa233).HasColumnName(@"PRSA233").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa234).HasColumnName(@"PRSA234").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa057).HasColumnName(@"PRSA057").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa560).HasColumnName(@"PRSA560").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa068).HasColumnName(@"PRSA068").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa070).HasColumnName(@"PRSA070").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa260).HasColumnName(@"PRSA260").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa261).HasColumnName(@"PRSA261").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa262).HasColumnName(@"PRSA262").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa211).HasColumnName(@"PRSA211").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa980).HasColumnName(@"PRSA980").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa981).HasColumnName(@"PRSA981").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa982).HasColumnName(@"PRSA982").HasColumnType("smallint").IsRequired();
            Property(x => x.Prsa983).HasColumnName(@"PRSA983").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa984).HasColumnName(@"PRSA984").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa985).HasColumnName(@"PRSA985").HasColumnType("tinyint").IsRequired();
            Property(x => x.Prsa055).HasColumnName(@"PRSA055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa083).HasColumnName(@"PRSA083").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa084).HasColumnName(@"PRSA084").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa218).HasColumnName(@"PRSA218").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa263).HasColumnName(@"PRSA263").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa695).HasColumnName(@"PRSA695").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa696).HasColumnName(@"PRSA696").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Prsa698).HasColumnName(@"PRSA698").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Prsa326).HasColumnName(@"PRSA326").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa678).HasColumnName(@"PRSA678").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Prsa241).HasColumnName(@"PRSA241").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa285).HasColumnName(@"PRSA285").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Prsa286).HasColumnName(@"PRSA286").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa327).HasColumnName(@"PRSA327").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa677).HasColumnName(@"PRSA677").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Prsa328).HasColumnName(@"PRSA328").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Prsa699).HasColumnName(@"PRSA699").HasColumnType("int").IsRequired();
            Property(x => x.Prsa037).HasColumnName(@"PRSA037").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Prsa287).HasColumnName(@"PRSA287").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Prsa281).HasColumnName(@"PRSA281").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa282).HasColumnName(@"PRSA282").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa750).HasColumnName(@"PRSA750").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Prsa284).HasColumnName(@"PRSA284").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa288).HasColumnName(@"PRSA288").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa289).HasColumnName(@"PRSA289").HasColumnType("datetime").IsRequired();
            Property(x => x.Prsa283).HasColumnName(@"PRSA283").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Prsa291).HasColumnName(@"PRSA291").HasColumnType("datetime").IsRequired();
        }
    }

}
