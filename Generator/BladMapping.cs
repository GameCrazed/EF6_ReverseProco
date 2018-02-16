

namespace Generator
{

    public class BladMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Blad>
    {
        public BladMapping()
            : this("dbo")
        {
        }

        public BladMapping(string schema)
        {
            ToTable("BLAD", schema);
            HasKey(x => x.Blad001);

            Property(x => x.Blad001).HasColumnName(@"BLAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Blad010).HasColumnName(@"BLAD010").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad020).HasColumnName(@"BLAD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Blad030).HasColumnName(@"BLAD030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad046).HasColumnName(@"BLAD046").HasColumnType("int").IsRequired();
            Property(x => x.Blad050).HasColumnName(@"BLAD050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad060).HasColumnName(@"BLAD060").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad070).HasColumnName(@"BLAD070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad100).HasColumnName(@"BLAD100").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad140).HasColumnName(@"BLAD140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad145).HasColumnName(@"BLAD145").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad150).HasColumnName(@"BLAD150").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad155).HasColumnName(@"BLAD155").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1701).HasColumnName(@"BLAD1701").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1702).HasColumnName(@"BLAD1702").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad175).HasColumnName(@"BLAD175").HasColumnType("tinyint").IsRequired();
            Property(x => x.Blad2521).HasColumnName(@"BLAD2521").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad2522).HasColumnName(@"BLAD2522").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad2523).HasColumnName(@"BLAD2523").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad2524).HasColumnName(@"BLAD2524").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad2541).HasColumnName(@"BLAD2541").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad2542).HasColumnName(@"BLAD2542").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad2543).HasColumnName(@"BLAD2543").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad2544).HasColumnName(@"BLAD2544").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad2561).HasColumnName(@"BLAD2561").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad2562).HasColumnName(@"BLAD2562").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad2563).HasColumnName(@"BLAD2563").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad2564).HasColumnName(@"BLAD2564").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad800).HasColumnName(@"BLAD800").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad810).HasColumnName(@"BLAD810").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad200).HasColumnName(@"BLAD200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Blad2011).HasColumnName(@"BLAD2011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Blad2012).HasColumnName(@"BLAD2012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Bladdtm).HasColumnName(@"BLADDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Blad035).HasColumnName(@"BLAD035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad607).HasColumnName(@"BLAD607").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Blad685).HasColumnName(@"BLAD685").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad700).HasColumnName(@"BLAD700").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad710).HasColumnName(@"BLAD710").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad720).HasColumnName(@"BLAD720").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Blad730).HasColumnName(@"BLAD730").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad105).HasColumnName(@"BLAD105").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad110).HasColumnName(@"BLAD110").HasColumnType("smallint").IsRequired();
            Property(x => x.Blad270).HasColumnName(@"BLAD270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Blad275).HasColumnName(@"BLAD275").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad280).HasColumnName(@"BLAD280").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad2571).HasColumnName(@"BLAD2571").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad2572).HasColumnName(@"BLAD2572").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad2573).HasColumnName(@"BLAD2573").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad2581).HasColumnName(@"BLAD2581").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Blad2582).HasColumnName(@"BLAD2582").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Blad2583).HasColumnName(@"BLAD2583").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Blad1541).HasColumnName(@"BLAD1541").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1542).HasColumnName(@"BLAD1542").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1543).HasColumnName(@"BLAD1543").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1544).HasColumnName(@"BLAD1544").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad152).HasColumnName(@"BLAD152").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1531).HasColumnName(@"BLAD1531").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1532).HasColumnName(@"BLAD1532").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1533).HasColumnName(@"BLAD1533").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1534).HasColumnName(@"BLAD1534").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1801).HasColumnName(@"BLAD1801").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1802).HasColumnName(@"BLAD1802").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad820).HasColumnName(@"BLAD820").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1511).HasColumnName(@"BLAD1511").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1512).HasColumnName(@"BLAD1512").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1513).HasColumnName(@"BLAD1513").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1514).HasColumnName(@"BLAD1514").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1515).HasColumnName(@"BLAD1515").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1516).HasColumnName(@"BLAD1516").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1517).HasColumnName(@"BLAD1517").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1535).HasColumnName(@"BLAD1535").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1536).HasColumnName(@"BLAD1536").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1537).HasColumnName(@"BLAD1537").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1545).HasColumnName(@"BLAD1545").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1546).HasColumnName(@"BLAD1546").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1547).HasColumnName(@"BLAD1547").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad157).HasColumnName(@"BLAD157").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad410).HasColumnName(@"BLAD410").HasColumnType("int").IsRequired();
            Property(x => x.Blad211).HasColumnName(@"BLAD211").HasColumnType("tinyint").IsRequired();
            Property(x => x.Blad1601).HasColumnName(@"BLAD1601").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1602).HasColumnName(@"BLAD1602").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1603).HasColumnName(@"BLAD1603").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1604).HasColumnName(@"BLAD1604").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1605).HasColumnName(@"BLAD1605").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1606).HasColumnName(@"BLAD1606").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1607).HasColumnName(@"BLAD1607").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad161).HasColumnName(@"BLAD161").HasColumnType("tinyint").IsRequired();
            Property(x => x.Blad1621).HasColumnName(@"BLAD1621").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1622).HasColumnName(@"BLAD1622").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1623).HasColumnName(@"BLAD1623").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1624).HasColumnName(@"BLAD1624").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1625).HasColumnName(@"BLAD1625").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1626).HasColumnName(@"BLAD1626").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad1627).HasColumnName(@"BLAD1627").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad212).HasColumnName(@"BLAD212").HasColumnType("tinyint").IsRequired();
            Property(x => x.Blad830).HasColumnName(@"BLAD830").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Blad840).HasColumnName(@"BLAD840").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Blad300).HasColumnName(@"BLAD300").HasColumnType("datetime").IsRequired();
            Property(x => x.Blad660).HasColumnName(@"BLAD660").HasColumnType("int").IsRequired();
        }
    }

}
