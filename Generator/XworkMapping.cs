

namespace Generator
{

    public class XworkMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Xwork>
    {
        public XworkMapping()
            : this("dbo")
        {
        }

        public XworkMapping(string schema)
        {
            ToTable("XWORK", schema);
            HasKey(x => x.Xwork010);

            Property(x => x.Xwork010).HasColumnName(@"XWORK010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xwork011).HasColumnName(@"XWORK011").HasColumnType("int").IsRequired();
            Property(x => x.Xwork015).HasColumnName(@"XWORK015").HasColumnType("int").IsRequired();
            Property(x => x.Xwork020).HasColumnName(@"XWORK020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Xwork025).HasColumnName(@"XWORK025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Xwork050).HasColumnName(@"XWORK050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xwork060).HasColumnName(@"XWORK060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Xwork070).HasColumnName(@"XWORK070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Xwork080).HasColumnName(@"XWORK080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Xwork090).HasColumnName(@"XWORK090").HasColumnType("datetime").IsRequired();
            Property(x => x.Xwork100).HasColumnName(@"XWORK100").HasColumnType("datetime").IsRequired();
            Property(x => x.Xwork110).HasColumnName(@"XWORK110").HasColumnType("datetime").IsRequired();
            Property(x => x.Xwork150).HasColumnName(@"XWORK150").HasColumnType("datetime").IsRequired();
            Property(x => x.Xwork160).HasColumnName(@"XWORK160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Xwork180).HasColumnName(@"XWORK180").HasColumnType("datetime").IsRequired();
            Property(x => x.Xwork190).HasColumnName(@"XWORK190").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Xwork200).HasColumnName(@"XWORK200").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Xwork030).HasColumnName(@"XWORK030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork1201).HasColumnName(@"XWORK1201").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1202).HasColumnName(@"XWORK1202").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1301).HasColumnName(@"XWORK1301").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1302).HasColumnName(@"XWORK1302").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1303).HasColumnName(@"XWORK1303").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1304).HasColumnName(@"XWORK1304").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1305).HasColumnName(@"XWORK1305").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1306).HasColumnName(@"XWORK1306").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1307).HasColumnName(@"XWORK1307").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork1308).HasColumnName(@"XWORK1308").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xwork2101).HasColumnName(@"XWORK2101").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2102).HasColumnName(@"XWORK2102").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2103).HasColumnName(@"XWORK2103").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2104).HasColumnName(@"XWORK2104").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2105).HasColumnName(@"XWORK2105").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2106).HasColumnName(@"XWORK2106").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2107).HasColumnName(@"XWORK2107").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2108).HasColumnName(@"XWORK2108").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2109).HasColumnName(@"XWORK2109").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork21010).HasColumnName(@"XWORK21010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork21011).HasColumnName(@"XWORK21011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork21012).HasColumnName(@"XWORK21012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork21013).HasColumnName(@"XWORK21013").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork21014).HasColumnName(@"XWORK21014").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork21015).HasColumnName(@"XWORK21015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xwork2201).HasColumnName(@"XWORK2201").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2202).HasColumnName(@"XWORK2202").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2203).HasColumnName(@"XWORK2203").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2204).HasColumnName(@"XWORK2204").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2205).HasColumnName(@"XWORK2205").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2206).HasColumnName(@"XWORK2206").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2207).HasColumnName(@"XWORK2207").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2208).HasColumnName(@"XWORK2208").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2209).HasColumnName(@"XWORK2209").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork22010).HasColumnName(@"XWORK22010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork22011).HasColumnName(@"XWORK22011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork22012).HasColumnName(@"XWORK22012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork22013).HasColumnName(@"XWORK22013").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork22014).HasColumnName(@"XWORK22014").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork22015).HasColumnName(@"XWORK22015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xwork2301).HasColumnName(@"XWORK2301").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork2302).HasColumnName(@"XWORK2302").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork2303).HasColumnName(@"XWORK2303").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork2304).HasColumnName(@"XWORK2304").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork2305).HasColumnName(@"XWORK2305").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork2306).HasColumnName(@"XWORK2306").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork2307).HasColumnName(@"XWORK2307").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork2308).HasColumnName(@"XWORK2308").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork2309).HasColumnName(@"XWORK2309").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork23010).HasColumnName(@"XWORK23010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork23011).HasColumnName(@"XWORK23011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork23012).HasColumnName(@"XWORK23012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork23013).HasColumnName(@"XWORK23013").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork23014).HasColumnName(@"XWORK23014").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xwork23015).HasColumnName(@"XWORK23015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Numkey).HasColumnName(@"numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Xworkdtm).HasColumnName(@"XWORKDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
