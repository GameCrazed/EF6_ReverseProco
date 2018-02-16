

namespace Generator
{

    public class PbudMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pbud>
    {
        public PbudMapping()
            : this("dbo")
        {
        }

        public PbudMapping(string schema)
        {
            ToTable("PBUD", schema);
            HasKey(x => new { x.Pbud010, x.Pbud020 });

            Property(x => x.Pbud010).HasColumnName(@"PBUD010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pbud020).HasColumnName(@"PBUD020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pbud030).HasColumnName(@"PBUD030").HasColumnType("int").IsRequired();
            Property(x => x.Pbud040).HasColumnName(@"PBUD040").HasColumnType("datetime").IsRequired();
            Property(x => x.Pbud1001).HasColumnName(@"PBUD1001").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1002).HasColumnName(@"PBUD1002").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1003).HasColumnName(@"PBUD1003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1004).HasColumnName(@"PBUD1004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1005).HasColumnName(@"PBUD1005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1006).HasColumnName(@"PBUD1006").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1007).HasColumnName(@"PBUD1007").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1008).HasColumnName(@"PBUD1008").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1009).HasColumnName(@"PBUD1009").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10010).HasColumnName(@"PBUD10010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10011).HasColumnName(@"PBUD10011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10012).HasColumnName(@"PBUD10012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10013).HasColumnName(@"PBUD10013").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10014).HasColumnName(@"PBUD10014").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10015).HasColumnName(@"PBUD10015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10016).HasColumnName(@"PBUD10016").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10017).HasColumnName(@"PBUD10017").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10018).HasColumnName(@"PBUD10018").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10019).HasColumnName(@"PBUD10019").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10020).HasColumnName(@"PBUD10020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10021).HasColumnName(@"PBUD10021").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10022).HasColumnName(@"PBUD10022").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10023).HasColumnName(@"PBUD10023").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10024).HasColumnName(@"PBUD10024").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10025).HasColumnName(@"PBUD10025").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10026).HasColumnName(@"PBUD10026").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10027).HasColumnName(@"PBUD10027").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10028).HasColumnName(@"PBUD10028").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10029).HasColumnName(@"PBUD10029").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10030).HasColumnName(@"PBUD10030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10031).HasColumnName(@"PBUD10031").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10032).HasColumnName(@"PBUD10032").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10033).HasColumnName(@"PBUD10033").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10034).HasColumnName(@"PBUD10034").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10035).HasColumnName(@"PBUD10035").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10036).HasColumnName(@"PBUD10036").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10037).HasColumnName(@"PBUD10037").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10038).HasColumnName(@"PBUD10038").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10039).HasColumnName(@"PBUD10039").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10040).HasColumnName(@"PBUD10040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10041).HasColumnName(@"PBUD10041").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10042).HasColumnName(@"PBUD10042").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10043).HasColumnName(@"PBUD10043").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10044).HasColumnName(@"PBUD10044").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10045).HasColumnName(@"PBUD10045").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10046).HasColumnName(@"PBUD10046").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10047).HasColumnName(@"PBUD10047").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10048).HasColumnName(@"PBUD10048").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10049).HasColumnName(@"PBUD10049").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10050).HasColumnName(@"PBUD10050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10051).HasColumnName(@"PBUD10051").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10052).HasColumnName(@"PBUD10052").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10053).HasColumnName(@"PBUD10053").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10054).HasColumnName(@"PBUD10054").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10055).HasColumnName(@"PBUD10055").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10056).HasColumnName(@"PBUD10056").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10057).HasColumnName(@"PBUD10057").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10058).HasColumnName(@"PBUD10058").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10059).HasColumnName(@"PBUD10059").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10060).HasColumnName(@"PBUD10060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10061).HasColumnName(@"PBUD10061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10062).HasColumnName(@"PBUD10062").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10063).HasColumnName(@"PBUD10063").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10064).HasColumnName(@"PBUD10064").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10065).HasColumnName(@"PBUD10065").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10066).HasColumnName(@"PBUD10066").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10067).HasColumnName(@"PBUD10067").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10068).HasColumnName(@"PBUD10068").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10069).HasColumnName(@"PBUD10069").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10070).HasColumnName(@"PBUD10070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10071).HasColumnName(@"PBUD10071").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10072).HasColumnName(@"PBUD10072").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10073).HasColumnName(@"PBUD10073").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10074).HasColumnName(@"PBUD10074").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud10075).HasColumnName(@"PBUD10075").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Pbud1101).HasColumnName(@"PBUD1101").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud1102).HasColumnName(@"PBUD1102").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud1103).HasColumnName(@"PBUD1103").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud1104).HasColumnName(@"PBUD1104").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud1105).HasColumnName(@"PBUD1105").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud1106).HasColumnName(@"PBUD1106").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud1107).HasColumnName(@"PBUD1107").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud1108).HasColumnName(@"PBUD1108").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud1109).HasColumnName(@"PBUD1109").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud11010).HasColumnName(@"PBUD11010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud11011).HasColumnName(@"PBUD11011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud11012).HasColumnName(@"PBUD11012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud11013).HasColumnName(@"PBUD11013").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud11014).HasColumnName(@"PBUD11014").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud11015).HasColumnName(@"PBUD11015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Pbud11016).HasColumnName(@"PBUD11016").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pbuddtm).HasColumnName(@"PBUDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Pbud120).HasColumnName(@"PBUD120").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
        }
    }

}
