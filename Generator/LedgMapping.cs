

namespace Generator
{

    public class LedgMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ledg>
    {
        public LedgMapping()
            : this("dbo")
        {
        }

        public LedgMapping(string schema)
        {
            ToTable("LEDG", schema);
            HasKey(x => x.Ledg010);

            Property(x => x.Ledg010).HasColumnName(@"LEDG010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ledg020).HasColumnName(@"LEDG020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg025).HasColumnName(@"LEDG025").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg030).HasColumnName(@"LEDG030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Ledg050).HasColumnName(@"LEDG050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg060).HasColumnName(@"LEDG060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg070).HasColumnName(@"LEDG070").HasColumnType("datetime").IsRequired();
            Property(x => x.Ledg080).HasColumnName(@"LEDG080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ledg090).HasColumnName(@"LEDG090").HasColumnType("datetime").IsRequired();
            Property(x => x.Ledg1101).HasColumnName(@"LEDG1101").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1102).HasColumnName(@"LEDG1102").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1103).HasColumnName(@"LEDG1103").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1104).HasColumnName(@"LEDG1104").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1105).HasColumnName(@"LEDG1105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1106).HasColumnName(@"LEDG1106").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1107).HasColumnName(@"LEDG1107").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1108).HasColumnName(@"LEDG1108").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1109).HasColumnName(@"LEDG1109").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg11010).HasColumnName(@"LEDG11010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg11011).HasColumnName(@"LEDG11011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg11012).HasColumnName(@"LEDG11012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ledg1401).HasColumnName(@"LEDG1401").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1402).HasColumnName(@"LEDG1402").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1403).HasColumnName(@"LEDG1403").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1404).HasColumnName(@"LEDG1404").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1405).HasColumnName(@"LEDG1405").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1406).HasColumnName(@"LEDG1406").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1407).HasColumnName(@"LEDG1407").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1408).HasColumnName(@"LEDG1408").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1409).HasColumnName(@"LEDG1409").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg14010).HasColumnName(@"LEDG14010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg14011).HasColumnName(@"LEDG14011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg14012).HasColumnName(@"LEDG14012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1601).HasColumnName(@"LEDG1601").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1602).HasColumnName(@"LEDG1602").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1603).HasColumnName(@"LEDG1603").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1604).HasColumnName(@"LEDG1604").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1605).HasColumnName(@"LEDG1605").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1606).HasColumnName(@"LEDG1606").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1607).HasColumnName(@"LEDG1607").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1608).HasColumnName(@"LEDG1608").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1609).HasColumnName(@"LEDG1609").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg16010).HasColumnName(@"LEDG16010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg16011).HasColumnName(@"LEDG16011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg16012).HasColumnName(@"LEDG16012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg1701).HasColumnName(@"LEDG1701").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg1702).HasColumnName(@"LEDG1702").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg1703).HasColumnName(@"LEDG1703").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg1704).HasColumnName(@"LEDG1704").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg1705).HasColumnName(@"LEDG1705").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg1706).HasColumnName(@"LEDG1706").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg1707).HasColumnName(@"LEDG1707").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg1708).HasColumnName(@"LEDG1708").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg1709).HasColumnName(@"LEDG1709").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg17010).HasColumnName(@"LEDG17010").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg17011).HasColumnName(@"LEDG17011").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg17012).HasColumnName(@"LEDG17012").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ledg040).HasColumnName(@"LEDG040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1201).HasColumnName(@"LEDG1201").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1202).HasColumnName(@"LEDG1202").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1203).HasColumnName(@"LEDG1203").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1204).HasColumnName(@"LEDG1204").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1205).HasColumnName(@"LEDG1205").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1206).HasColumnName(@"LEDG1206").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1207).HasColumnName(@"LEDG1207").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1208).HasColumnName(@"LEDG1208").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg1209).HasColumnName(@"LEDG1209").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg12010).HasColumnName(@"LEDG12010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg12011).HasColumnName(@"LEDG12011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ledg12012).HasColumnName(@"LEDG12012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ledgdtm).HasColumnName(@"LEDGDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Ledg062).HasColumnName(@"LEDG062").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ledg095).HasColumnName(@"LEDG095").HasColumnType("int").IsRequired();
            Property(x => x.Ledg100).HasColumnName(@"LEDG100").HasColumnType("datetime").IsRequired();
        }
    }

}
