

namespace Generator
{

    public class CompMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Comp>
    {
        public CompMapping()
            : this("dbo")
        {
        }

        public CompMapping(string schema)
        {
            ToTable("COMP", schema);
            HasKey(x => x.Comp010);

            Property(x => x.Comp010).HasColumnName(@"COMP010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Comp040).HasColumnName(@"COMP040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Comp042).HasColumnName(@"COMP042").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Comp060).HasColumnName(@"COMP060").HasColumnType("smallint").IsRequired();
            Property(x => x.Comp070).HasColumnName(@"COMP070").HasColumnType("smallint").IsRequired();
            Property(x => x.Comp080).HasColumnName(@"COMP080").HasColumnType("smallint").IsRequired();
            Property(x => x.Comp095).HasColumnName(@"COMP095").HasColumnType("int").IsRequired();
            Property(x => x.Comp120).HasColumnName(@"COMP120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp130).HasColumnName(@"COMP130").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp140).HasColumnName(@"COMP140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Comp150).HasColumnName(@"COMP150").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp210).HasColumnName(@"COMP210").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp220).HasColumnName(@"COMP220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp2301).HasColumnName(@"COMP2301").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2302).HasColumnName(@"COMP2302").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2303).HasColumnName(@"COMP2303").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2304).HasColumnName(@"COMP2304").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2305).HasColumnName(@"COMP2305").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2306).HasColumnName(@"COMP2306").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2307).HasColumnName(@"COMP2307").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2308).HasColumnName(@"COMP2308").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2309).HasColumnName(@"COMP2309").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp23010).HasColumnName(@"COMP23010").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp23011).HasColumnName(@"COMP23011").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp23012).HasColumnName(@"COMP23012").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp23013).HasColumnName(@"COMP23013").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2401).HasColumnName(@"COMP2401").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2402).HasColumnName(@"COMP2402").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2403).HasColumnName(@"COMP2403").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2404).HasColumnName(@"COMP2404").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2405).HasColumnName(@"COMP2405").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2406).HasColumnName(@"COMP2406").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2407).HasColumnName(@"COMP2407").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2408).HasColumnName(@"COMP2408").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp2409).HasColumnName(@"COMP2409").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp24010).HasColumnName(@"COMP24010").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp24011).HasColumnName(@"COMP24011").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp24012).HasColumnName(@"COMP24012").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp24013).HasColumnName(@"COMP24013").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp260).HasColumnName(@"COMP260").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp270).HasColumnName(@"COMP270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp275).HasColumnName(@"COMP275").HasColumnType("smallint").IsRequired();
            Property(x => x.Comp277).HasColumnName(@"COMP277").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Comp280).HasColumnName(@"COMP280").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp290).HasColumnName(@"COMP290").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp300).HasColumnName(@"COMP300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Comp330).HasColumnName(@"COMP330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp340).HasColumnName(@"COMP340").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp350).HasColumnName(@"COMP350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Comp360).HasColumnName(@"COMP360").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp370).HasColumnName(@"COMP370").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Comp390).HasColumnName(@"COMP390").HasColumnType("int").IsRequired();
            Property(x => x.Comp5001).HasColumnName(@"COMP5001").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp5002).HasColumnName(@"COMP5002").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp5003).HasColumnName(@"COMP5003").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp5004).HasColumnName(@"COMP5004").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp5005).HasColumnName(@"COMP5005").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp5006).HasColumnName(@"COMP5006").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp5007).HasColumnName(@"COMP5007").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp5008).HasColumnName(@"COMP5008").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp5009).HasColumnName(@"COMP5009").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp501).HasColumnName(@"COMP501").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp510).HasColumnName(@"COMP510").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Comp520).HasColumnName(@"COMP520").HasColumnType("int").IsRequired();
            Property(x => x.Comp530).HasColumnName(@"COMP530").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(18);
            Property(x => x.Comp050).HasColumnName(@"COMP050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Comp440).HasColumnName(@"COMP440").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(120);
            Property(x => x.Comp450).HasColumnName(@"COMP450").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(180);
            Property(x => x.Comp460).HasColumnName(@"COMP460").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(180);
            Property(x => x.Comp470).HasColumnName(@"COMP470").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(180);
            Property(x => x.Comp540).HasColumnName(@"COMP540").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Compdtm).HasColumnName(@"COMPDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Comp550).HasColumnName(@"COMP550").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp160).HasColumnName(@"COMP160").HasColumnType("int").IsRequired();
            Property(x => x.Comp531).HasColumnName(@"COMP531").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(18);
            Property(x => x.Comp100).HasColumnName(@"COMP100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Comp105).HasColumnName(@"COMP105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Comp110).HasColumnName(@"COMP110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp115).HasColumnName(@"COMP115").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp116).HasColumnName(@"COMP116").HasColumnType("int").IsRequired();
            Property(x => x.Comp170).HasColumnName(@"COMP170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Comp109).HasColumnName(@"COMP109").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp180).HasColumnName(@"COMP180").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Comp190).HasColumnName(@"COMP190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Comp200).HasColumnName(@"COMP200").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Comp265).HasColumnName(@"COMP265").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp900).HasColumnName(@"COMP900").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Comp910).HasColumnName(@"COMP910").HasColumnType("int").IsRequired();
            Property(x => x.Comp560).HasColumnName(@"COMP560").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Comp135).HasColumnName(@"COMP135").HasColumnType("int").IsRequired();
            Property(x => x.Comp570).HasColumnName(@"COMP570").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Comp043).HasColumnName(@"COMP043").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Comp044).HasColumnName(@"COMP044").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Comp503).HasColumnName(@"COMP503").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp504).HasColumnName(@"COMP504").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp235).HasColumnName(@"COMP235").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp9201).HasColumnName(@"COMP9201").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp9202).HasColumnName(@"COMP9202").HasColumnType("tinyint").IsRequired();
            Property(x => x.Comp925).HasColumnName(@"COMP925").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Comp600).HasColumnName(@"COMP600").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp610).HasColumnName(@"COMP610").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Comp620).HasColumnName(@"COMP620").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp630).HasColumnName(@"COMP630").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Comp640).HasColumnName(@"COMP640").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Comp096).HasColumnName(@"COMP096").HasColumnType("int").IsRequired();
            Property(x => x.Comp650).HasColumnName(@"COMP650").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Comp652).HasColumnName(@"COMP652").HasColumnType("int").IsRequired();
            Property(x => x.Comp654).HasColumnName(@"COMP654").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp655).HasColumnName(@"COMP655").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp658).HasColumnName(@"COMP658").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp659).HasColumnName(@"COMP659").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6601).HasColumnName(@"COMP6601").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6602).HasColumnName(@"COMP6602").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6603).HasColumnName(@"COMP6603").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6604).HasColumnName(@"COMP6604").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6605).HasColumnName(@"COMP6605").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6606).HasColumnName(@"COMP6606").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6607).HasColumnName(@"COMP6607").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6608).HasColumnName(@"COMP6608").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp6609).HasColumnName(@"COMP6609").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp66010).HasColumnName(@"COMP66010").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Comp045).HasColumnName(@"COMP045").HasColumnType("int").IsRequired();
            Property(x => x.Comp117).HasColumnName(@"COMP117").HasColumnType("int").IsRequired();
            Property(x => x.Comp118).HasColumnName(@"COMP118").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comp546).HasColumnName(@"COMP546").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Comp136).HasColumnName(@"COMP136").HasColumnType("datetime").IsRequired();
            Property(x => x.Comp930).HasColumnName(@"COMP930").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
