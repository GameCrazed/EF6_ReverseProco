

namespace Generator
{

    public class QuotMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Quot>
    {
        public QuotMapping()
            : this("dbo")
        {
        }

        public QuotMapping(string schema)
        {
            ToTable("QUOT", schema);
            HasKey(x => x.Quot999);

            Property(x => x.Quot999).HasColumnName(@"QUOT999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Quot010).HasColumnName(@"QUOT010").HasColumnType("int").IsRequired();
            Property(x => x.Quot020).HasColumnName(@"QUOT020").HasColumnType("datetime").IsRequired();
            Property(x => x.Quot030).HasColumnName(@"QUOT030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Quot040).HasColumnName(@"QUOT040").HasColumnType("datetime").IsRequired();
            Property(x => x.Quot050).HasColumnName(@"QUOT050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot060).HasColumnName(@"QUOT060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot070).HasColumnName(@"QUOT070").HasColumnType("int").IsRequired();
            Property(x => x.Quot080).HasColumnName(@"QUOT080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot085).HasColumnName(@"QUOT085").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot090).HasColumnName(@"QUOT090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot100).HasColumnName(@"QUOT100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot105).HasColumnName(@"QUOT105").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot110).HasColumnName(@"QUOT110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot120).HasColumnName(@"QUOT120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot130).HasColumnName(@"QUOT130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot135).HasColumnName(@"QUOT135").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot140).HasColumnName(@"QUOT140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot145).HasColumnName(@"QUOT145").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot150).HasColumnName(@"QUOT150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot160).HasColumnName(@"QUOT160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot170).HasColumnName(@"QUOT170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot180).HasColumnName(@"QUOT180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot190).HasColumnName(@"QUOT190").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot200).HasColumnName(@"QUOT200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot210).HasColumnName(@"QUOT210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot212).HasColumnName(@"QUOT212").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot214).HasColumnName(@"QUOT214").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot230).HasColumnName(@"QUOT230").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot240).HasColumnName(@"QUOT240").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot400).HasColumnName(@"QUOT400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot410).HasColumnName(@"QUOT410").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot420).HasColumnName(@"QUOT420").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot500).HasColumnName(@"QUOT500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot510).HasColumnName(@"QUOT510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot520).HasColumnName(@"QUOT520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot530).HasColumnName(@"QUOT530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot535).HasColumnName(@"QUOT535").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot540).HasColumnName(@"QUOT540").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot600).HasColumnName(@"QUOT600").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot610).HasColumnName(@"QUOT610").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot620).HasColumnName(@"QUOT620").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot630).HasColumnName(@"QUOT630").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot640).HasColumnName(@"QUOT640").HasColumnType("int").IsRequired();
            Property(x => x.Quot650).HasColumnName(@"QUOT650").HasColumnType("int").IsRequired();
            Property(x => x.Quot700).HasColumnName(@"QUOT700").HasColumnType("int").IsRequired();
            Property(x => x.Quot710).HasColumnName(@"QUOT710").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Quot800).HasColumnName(@"QUOT800").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot801).HasColumnName(@"QUOT801").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot802).HasColumnName(@"QUOT802").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot803).HasColumnName(@"QUOT803").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot804).HasColumnName(@"QUOT804").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot805).HasColumnName(@"QUOT805").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot806).HasColumnName(@"QUOT806").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot807).HasColumnName(@"QUOT807").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot808).HasColumnName(@"QUOT808").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot809).HasColumnName(@"QUOT809").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot810).HasColumnName(@"QUOT810").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot811).HasColumnName(@"QUOT811").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot812).HasColumnName(@"QUOT812").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot815).HasColumnName(@"QUOT815").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot816).HasColumnName(@"QUOT816").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot817).HasColumnName(@"QUOT817").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot818).HasColumnName(@"QUOT818").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot819).HasColumnName(@"QUOT819").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot820).HasColumnName(@"QUOT820").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot830).HasColumnName(@"QUOT830").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot840).HasColumnName(@"QUOT840").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot850).HasColumnName(@"QUOT850").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot860).HasColumnName(@"QUOT860").HasColumnType("datetime").IsRequired();
            Property(x => x.Quotdtm).HasColumnName(@"QUOTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Quot048).HasColumnName(@"QUOT048").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Quot035).HasColumnName(@"QUOT035").HasColumnType("int").IsRequired();
            Property(x => x.Quot041).HasColumnName(@"QUOT041").HasColumnType("datetime").IsRequired();
            Property(x => x.Quot051).HasColumnName(@"QUOT051").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot055).HasColumnName(@"QUOT055").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Quot720).HasColumnName(@"QUOT720").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Quot730).HasColumnName(@"QUOT730").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Quot740).HasColumnName(@"QUOT740").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot831).HasColumnName(@"QUOT831").HasColumnType("datetime").IsRequired();
            Property(x => x.Quot861).HasColumnName(@"QUOT861").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot862).HasColumnName(@"QUOT862").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot855).HasColumnName(@"QUOT855").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot865).HasColumnName(@"QUOT865").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Quot501).HasColumnName(@"QUOT501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot780).HasColumnName(@"QUOT780").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot790).HasColumnName(@"QUOT790").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot792).HasColumnName(@"QUOT792").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot795).HasColumnName(@"QUOT795").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot796).HasColumnName(@"QUOT796").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot797).HasColumnName(@"QUOT797").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot798).HasColumnName(@"QUOT798").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot799).HasColumnName(@"QUOT799").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot824).HasColumnName(@"QUOT824").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot825).HasColumnName(@"QUOT825").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot8271).HasColumnName(@"QUOT8271").HasColumnType("smallint").IsRequired();
            Property(x => x.Quot8272).HasColumnName(@"QUOT8272").HasColumnType("smallint").IsRequired();
            Property(x => x.Quot8281).HasColumnName(@"QUOT8281").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot8282).HasColumnName(@"QUOT8282").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot8291).HasColumnName(@"QUOT8291").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot8292).HasColumnName(@"QUOT8292").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot900).HasColumnName(@"QUOT900").HasColumnType("int").IsRequired();
            Property(x => x.Quot785).HasColumnName(@"QUOT785").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot870).HasColumnName(@"QUOT870").HasColumnType("datetime").IsRequired();
            Property(x => x.Quot872).HasColumnName(@"QUOT872").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot550).HasColumnName(@"QUOT550").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Quot552).HasColumnName(@"QUOT552").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot554).HasColumnName(@"QUOT554").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Quot556).HasColumnName(@"QUOT556").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot558).HasColumnName(@"QUOT558").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot560).HasColumnName(@"QUOT560").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot149).HasColumnName(@"QUOT149").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot580).HasColumnName(@"QUOT580").HasColumnType("datetime").IsRequired();
            Property(x => x.Quot582).HasColumnName(@"QUOT582").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot584).HasColumnName(@"QUOT584").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot586).HasColumnName(@"QUOT586").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot588).HasColumnName(@"QUOT588").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Quot590).HasColumnName(@"QUOT590").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Quot592).HasColumnName(@"QUOT592").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Quot594).HasColumnName(@"QUOT594").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Quot596).HasColumnName(@"QUOT596").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot597).HasColumnName(@"QUOT597").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot598).HasColumnName(@"QUOT598").HasColumnType("datetime").IsRequired();
            Property(x => x.Quot910).HasColumnName(@"QUOT910").HasColumnType("int").IsRequired();
            Property(x => x.Quot920).HasColumnName(@"QUOT920").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Quot760).HasColumnName(@"QUOT760").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot761).HasColumnName(@"QUOT761").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot762).HasColumnName(@"QUOT762").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot763).HasColumnName(@"QUOT763").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot764).HasColumnName(@"QUOT764").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot765).HasColumnName(@"QUOT765").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot766).HasColumnName(@"QUOT766").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot767).HasColumnName(@"QUOT767").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot768).HasColumnName(@"QUOT768").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Quot769).HasColumnName(@"QUOT769").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quot770).HasColumnName(@"QUOT770").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot771).HasColumnName(@"QUOT771").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot772).HasColumnName(@"QUOT772").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot773).HasColumnName(@"QUOT773").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot774).HasColumnName(@"QUOT774").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Quot856).HasColumnName(@"QUOT856").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
