

namespace Generator
{

    public class PerMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Per>
    {
        public PerMapping()
            : this("dbo")
        {
        }

        public PerMapping(string schema)
        {
            ToTable("PERS", schema);
            HasKey(x => x.Pers010);

            Property(x => x.Pers010).HasColumnName(@"PERS010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pers015).HasColumnName(@"PERS015").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pers020).HasColumnName(@"PERS020").HasColumnType("int").IsRequired();
            Property(x => x.Pers040).HasColumnName(@"PERS040").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers050).HasColumnName(@"PERS050").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers060).HasColumnName(@"PERS060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers080).HasColumnName(@"PERS080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers090).HasColumnName(@"PERS090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers091).HasColumnName(@"PERS091").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers092).HasColumnName(@"PERS092").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Pers1001).HasColumnName(@"PERS1001").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1002).HasColumnName(@"PERS1002").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1003).HasColumnName(@"PERS1003").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1004).HasColumnName(@"PERS1004").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1005).HasColumnName(@"PERS1005").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1101).HasColumnName(@"PERS1101").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1102).HasColumnName(@"PERS1102").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1103).HasColumnName(@"PERS1103").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1104).HasColumnName(@"PERS1104").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1105).HasColumnName(@"PERS1105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers120).HasColumnName(@"PERS120").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers140).HasColumnName(@"PERS140").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers170).HasColumnName(@"PERS170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Pers210).HasColumnName(@"PERS210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers220).HasColumnName(@"PERS220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers225).HasColumnName(@"PERS225").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers230).HasColumnName(@"PERS230").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers240).HasColumnName(@"PERS240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers160).HasColumnName(@"PERS160").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pers180).HasColumnName(@"PERS180").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Persdtm).HasColumnName(@"PERSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Pers055).HasColumnName(@"PERS055").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pers057).HasColumnName(@"PERS057").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pers400).HasColumnName(@"PERS400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pers070).HasColumnName(@"PERS070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pers095).HasColumnName(@"PERS095").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pers112).HasColumnName(@"PERS112").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pers114).HasColumnName(@"PERS114").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pers125).HasColumnName(@"PERS125").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers130).HasColumnName(@"PERS130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers135).HasColumnName(@"PERS135").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers145).HasColumnName(@"PERS145").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers150).HasColumnName(@"PERS150").HasColumnType("smallint").IsRequired();
            Property(x => x.Pers165).HasColumnName(@"PERS165").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Pers190).HasColumnName(@"PERS190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pers450).HasColumnName(@"PERS450").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pers500).HasColumnName(@"PERS500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers510).HasColumnName(@"PERS510").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers520).HasColumnName(@"PERS520").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pers600).HasColumnName(@"PERS600").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Pers610).HasColumnName(@"PERS610").HasColumnType("int").IsRequired();
            Property(x => x.Pers530).HasColumnName(@"PERS530").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Pers051).HasColumnName(@"PERS051").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pers056).HasColumnName(@"PERS056").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pers041).HasColumnName(@"PERS041").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers1011).HasColumnName(@"PERS1011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1012).HasColumnName(@"PERS1012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1013).HasColumnName(@"PERS1013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1014).HasColumnName(@"PERS1014").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1015).HasColumnName(@"PERS1015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers162).HasColumnName(@"PERS162").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Pers1006).HasColumnName(@"PERS1006").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1007).HasColumnName(@"PERS1007").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1008).HasColumnName(@"PERS1008").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1009).HasColumnName(@"PERS1009").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers10010).HasColumnName(@"PERS10010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers1016).HasColumnName(@"PERS1016").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1017).HasColumnName(@"PERS1017").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1018).HasColumnName(@"PERS1018").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1019).HasColumnName(@"PERS1019").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers10110).HasColumnName(@"PERS10110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1106).HasColumnName(@"PERS1106").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1107).HasColumnName(@"PERS1107").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1108).HasColumnName(@"PERS1108").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers1109).HasColumnName(@"PERS1109").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers11010).HasColumnName(@"PERS11010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers200).HasColumnName(@"PERS200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers205).HasColumnName(@"PERS205").HasColumnType("int").IsRequired();
            Property(x => x.Pers042).HasColumnName(@"PERS042").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers740).HasColumnName(@"PERS740").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pers742).HasColumnName(@"PERS742").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pers745).HasColumnName(@"PERS745").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Pers747).HasColumnName(@"PERS747").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pers751).HasColumnName(@"PERS751").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pers550).HasColumnName(@"PERS550").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers555).HasColumnName(@"PERS555").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers560).HasColumnName(@"PERS560").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pers565).HasColumnName(@"PERS565").HasColumnType("int").IsRequired();
            Property(x => x.Pers567).HasColumnName(@"PERS567").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers093).HasColumnName(@"PERS093").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Pers096).HasColumnName(@"PERS096").HasColumnType("int").IsRequired();
            Property(x => x.Pers360).HasColumnName(@"PERS360").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers290).HasColumnName(@"PERS290").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers365).HasColumnName(@"PERS365").HasColumnType("smallint").IsRequired();
            Property(x => x.Pers097).HasColumnName(@"PERS097").HasColumnType("smallint").IsRequired();
            Property(x => x.Pers370).HasColumnName(@"PERS370").HasColumnType("smallint").IsRequired();
            Property(x => x.Pers535).HasColumnName(@"PERS535").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers375).HasColumnName(@"PERS375").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers017).HasColumnName(@"PERS017").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Pers044).HasColumnName(@"PERS044").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers098).HasColumnName(@"PERS098").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers460).HasColumnName(@"PERS460").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pers470).HasColumnName(@"PERS470").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pers043).HasColumnName(@"PERS043").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers105).HasColumnName(@"PERS105").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pers215).HasColumnName(@"PERS215").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Pers071).HasColumnName(@"PERS071").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pers075).HasColumnName(@"PERS075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pers078).HasColumnName(@"PERS078").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers079).HasColumnName(@"PERS079").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers195).HasColumnName(@"PERS195").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pers196).HasColumnName(@"PERS196").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers197).HasColumnName(@"PERS197").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers380).HasColumnName(@"PERS380").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers385).HasColumnName(@"PERS385").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers390).HasColumnName(@"PERS390").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers490).HasColumnName(@"PERS490").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pers491).HasColumnName(@"PERS491").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pers800).HasColumnName(@"PERS800").HasColumnType("datetime").IsRequired();
            Property(x => x.Pers801).HasColumnName(@"PERS801").HasColumnType("int").IsRequired();
            Property(x => x.Pers166).HasColumnName(@"PERS166").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers760).HasColumnName(@"PERS760").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pers175).HasColumnName(@"PERS175").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Pers076).HasColumnName(@"PERS076").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
