

namespace Generator
{

    public class CustMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cust>
    {
        public CustMapping()
            : this("dbo")
        {
        }

        public CustMapping(string schema)
        {
            ToTable("CUST", schema);
            HasKey(x => x.Cust010);

            Property(x => x.Cust010).HasColumnName(@"CUST010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cust040).HasColumnName(@"CUST040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cust046).HasColumnName(@"CUST046").HasColumnType("int").IsRequired();
            Property(x => x.Cust060).HasColumnName(@"CUST060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cust070).HasColumnName(@"CUST070").HasColumnType("datetime").IsRequired();
            Property(x => x.Cust080).HasColumnName(@"CUST080").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Cust090).HasColumnName(@"CUST090").HasColumnType("int").IsRequired();
            Property(x => x.Cust100).HasColumnName(@"CUST100").HasColumnType("datetime").IsRequired();
            Property(x => x.Cust111).HasColumnName(@"CUST111").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust112).HasColumnName(@"CUST112").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cust113).HasColumnName(@"CUST113").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust120).HasColumnName(@"CUST120").HasColumnType("datetime").IsRequired();
            Property(x => x.Cust130).HasColumnName(@"CUST130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cust210).HasColumnName(@"CUST210").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cust220).HasColumnName(@"CUST220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Cust230).HasColumnName(@"CUST230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cust240).HasColumnName(@"CUST240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust260).HasColumnName(@"CUST260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust300).HasColumnName(@"CUST300").HasColumnType("int").IsRequired();
            Property(x => x.Cust310).HasColumnName(@"CUST310").HasColumnType("int").IsRequired();
            Property(x => x.Cust050).HasColumnName(@"CUST050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Custdtm).HasColumnName(@"CUSTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Cust305).HasColumnName(@"CUST305").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Cust270).HasColumnName(@"CUST270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust265).HasColumnName(@"CUST265").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust267).HasColumnName(@"CUST267").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust280).HasColumnName(@"CUST280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust020).HasColumnName(@"CUST020").HasColumnType("int").IsRequired();
            Property(x => x.Cust281).HasColumnName(@"CUST281").HasColumnType("datetime").IsRequired();
            Property(x => x.Cust320).HasColumnName(@"CUST320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust325).HasColumnName(@"CUST325").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cust283).HasColumnName(@"CUST283").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust402).HasColumnName(@"CUST402").HasColumnType("int").IsRequired();
            Property(x => x.Cust412).HasColumnName(@"CUST412").HasColumnType("datetime").IsRequired();
            Property(x => x.Cust330).HasColumnName(@"CUST330").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cust340).HasColumnName(@"CUST340").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cust290).HasColumnName(@"CUST290").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust092).HasColumnName(@"CUST092").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust085).HasColumnName(@"CUST085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust282).HasColumnName(@"CUST282").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust284).HasColumnName(@"CUST284").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust311).HasColumnName(@"CUST311").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust312).HasColumnName(@"CUST312").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cust313).HasColumnName(@"CUST313").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
