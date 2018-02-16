

namespace Generator
{

    public class CladMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Clad>
    {
        public CladMapping()
            : this("dbo")
        {
        }

        public CladMapping(string schema)
        {
            ToTable("CLAD", schema);
            HasKey(x => x.Clad001);

            Property(x => x.Clad001).HasColumnName(@"CLAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Clad002).HasColumnName(@"CLAD002").HasColumnType("int").IsRequired();
            Property(x => x.Clad010).HasColumnName(@"CLAD010").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad020).HasColumnName(@"CLAD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Clad030).HasColumnName(@"CLAD030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad040).HasColumnName(@"CLAD040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad044).HasColumnName(@"CLAD044").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad045).HasColumnName(@"CLAD045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad046).HasColumnName(@"CLAD046").HasColumnType("int").IsRequired();
            Property(x => x.Clad047).HasColumnName(@"CLAD047").HasColumnType("int").IsRequired();
            Property(x => x.Clad048).HasColumnName(@"CLAD048").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Clad0491).HasColumnName(@"CLAD0491").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad0492).HasColumnName(@"CLAD0492").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad050).HasColumnName(@"CLAD050").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad052).HasColumnName(@"CLAD052").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad054).HasColumnName(@"CLAD054").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad058).HasColumnName(@"CLAD058").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad062).HasColumnName(@"CLAD062").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad110).HasColumnName(@"CLAD110").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad140).HasColumnName(@"CLAD140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad150).HasColumnName(@"CLAD150").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad160).HasColumnName(@"CLAD160").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad170).HasColumnName(@"CLAD170").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad180).HasColumnName(@"CLAD180").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Clad201).HasColumnName(@"CLAD201").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad202).HasColumnName(@"CLAD202").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad204).HasColumnName(@"CLAD204").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad205).HasColumnName(@"CLAD205").HasColumnType("int").IsRequired();
            Property(x => x.Clad206).HasColumnName(@"CLAD206").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad207).HasColumnName(@"CLAD207").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad208).HasColumnName(@"CLAD208").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad240).HasColumnName(@"CLAD240").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad250).HasColumnName(@"CLAD250").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad260).HasColumnName(@"CLAD260").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad270).HasColumnName(@"CLAD270").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad280).HasColumnName(@"CLAD280").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad285).HasColumnName(@"CLAD285").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad300).HasColumnName(@"CLAD300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad310).HasColumnName(@"CLAD310").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad315).HasColumnName(@"CLAD315").HasColumnType("int").IsRequired();
            Property(x => x.Clad320).HasColumnName(@"CLAD320").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad330).HasColumnName(@"CLAD330").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad350).HasColumnName(@"CLAD350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Clad360).HasColumnName(@"CLAD360").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad365).HasColumnName(@"CLAD365").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad670).HasColumnName(@"CLAD670").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Clad680).HasColumnName(@"CLAD680").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad690).HasColumnName(@"CLAD690").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Clad700).HasColumnName(@"CLAD700").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad705).HasColumnName(@"CLAD705").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Clad710).HasColumnName(@"CLAD710").HasColumnType("int").IsRequired();
            Property(x => x.Clad720).HasColumnName(@"CLAD720").HasColumnType("int").IsRequired();
            Property(x => x.Clad730).HasColumnName(@"CLAD730").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad735).HasColumnName(@"CLAD735").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad740).HasColumnName(@"CLAD740").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad750).HasColumnName(@"CLAD750").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad699).HasColumnName(@"CLAD699").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad200).HasColumnName(@"CLAD200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Clad290).HasColumnName(@"CLAD290").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Clad335).HasColumnName(@"CLAD335").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(18);
            Property(x => x.Claddtm).HasColumnName(@"CLADDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Clad760).HasColumnName(@"CLAD760").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad695).HasColumnName(@"CLAD695").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad080).HasColumnName(@"CLAD080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad337).HasColumnName(@"CLAD337").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Clad770).HasColumnName(@"CLAD770").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad190).HasColumnName(@"CLAD190").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad370).HasColumnName(@"CLAD370").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad737).HasColumnName(@"CLAD737").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Clad731).HasColumnName(@"CLAD731").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad732).HasColumnName(@"CLAD732").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad733).HasColumnName(@"CLAD733").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Clad734).HasColumnName(@"CLAD734").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad736).HasColumnName(@"CLAD736").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad738).HasColumnName(@"CLAD738").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad090).HasColumnName(@"CLAD090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad230).HasColumnName(@"CLAD230").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad231).HasColumnName(@"CLAD231").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad232).HasColumnName(@"CLAD232").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad233).HasColumnName(@"CLAD233").HasColumnType("int").IsRequired();
            Property(x => x.Clad100).HasColumnName(@"CLAD100").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad101).HasColumnName(@"CLAD101").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad102).HasColumnName(@"CLAD102").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad130).HasColumnName(@"CLAD130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad035).HasColumnName(@"CLAD035").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Clad120).HasColumnName(@"CLAD120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Clad772).HasColumnName(@"CLAD772").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad775).HasColumnName(@"CLAD775").HasColumnType("int").IsRequired();
            Property(x => x.Clad739).HasColumnName(@"CLAD739").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad800).HasColumnName(@"CLAD800").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad801).HasColumnName(@"CLAD801").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad802).HasColumnName(@"CLAD802").HasColumnType("int").IsRequired();
            Property(x => x.Clad083).HasColumnName(@"CLAD083").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad084).HasColumnName(@"CLAD084").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad085).HasColumnName(@"CLAD085").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad086).HasColumnName(@"CLAD086").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad087).HasColumnName(@"CLAD087").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad088).HasColumnName(@"CLAD088").HasColumnType("smallint").IsRequired();
            Property(x => x.Clad043).HasColumnName(@"CLAD043").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad067).HasColumnName(@"CLAD067").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad095).HasColumnName(@"CLAD095").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad7771).HasColumnName(@"CLAD7771").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad7772).HasColumnName(@"CLAD7772").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad210).HasColumnName(@"CLAD210").HasColumnType("int").IsRequired();
            Property(x => x.Clad822).HasColumnName(@"CLAD822").HasColumnType("int").IsRequired();
            Property(x => x.Clad209).HasColumnName(@"CLAD209").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Clad091).HasColumnName(@"CLAD091").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad092).HasColumnName(@"CLAD092").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad073).HasColumnName(@"CLAD073").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Clad075).HasColumnName(@"CLAD075").HasColumnType("int").IsRequired();
            Property(x => x.Clad038).HasColumnName(@"CLAD038").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad104).HasColumnName(@"CLAD104").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad703).HasColumnName(@"CLAD703").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad825).HasColumnName(@"CLAD825").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad827).HasColumnName(@"CLAD827").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad711).HasColumnName(@"CLAD711").HasColumnType("int").IsRequired();
            Property(x => x.Clad211).HasColumnName(@"CLAD211").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad840).HasColumnName(@"CLAD840").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad845).HasColumnName(@"CLAD845").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad830).HasColumnName(@"CLAD830").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad216).HasColumnName(@"CLAD216").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad217).HasColumnName(@"CLAD217").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad234).HasColumnName(@"CLAD234").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad031).HasColumnName(@"CLAD031").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad032).HasColumnName(@"CLAD032").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Clad033).HasColumnName(@"CLAD033").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Clad915).HasColumnName(@"CLAD915").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad920).HasColumnName(@"CLAD920").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Clad034).HasColumnName(@"CLAD034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad037).HasColumnName(@"CLAD037").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad355).HasColumnName(@"CLAD355").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad356).HasColumnName(@"CLAD356").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Clad357).HasColumnName(@"CLAD357").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad358).HasColumnName(@"CLAD358").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Clad372).HasColumnName(@"CLAD372").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad103).HasColumnName(@"CLAD103").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Clad125).HasColumnName(@"CLAD125").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad316).HasColumnName(@"CLAD316").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad400).HasColumnName(@"CLAD400").HasColumnType("int").IsRequired();
            Property(x => x.Clad410).HasColumnName(@"CLAD410").HasColumnType("tinyint").IsRequired();
            Property(x => x.Clad097).HasColumnName(@"CLAD097").HasColumnType("datetime").IsRequired();
            Property(x => x.Clad098).HasColumnName(@"CLAD098").HasColumnType("datetime").IsRequired();
        }
    }

}
