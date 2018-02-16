

namespace Generator
{

    public class BordMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Bord>
    {
        public BordMapping()
            : this("dbo")
        {
        }

        public BordMapping(string schema)
        {
            ToTable("BORD", schema);
            HasKey(x => x.Bord999);

            Property(x => x.Bord020).HasColumnName(@"BORD020").HasColumnType("int").IsRequired();
            Property(x => x.Bord025).HasColumnName(@"BORD025").HasColumnType("datetime").IsRequired();
            Property(x => x.Bord030).HasColumnName(@"BORD030").HasColumnType("datetime").IsRequired();
            Property(x => x.Bord040).HasColumnName(@"BORD040").HasColumnType("datetime").IsRequired();
            Property(x => x.Bord050).HasColumnName(@"BORD050").HasColumnType("smallint").IsRequired();
            Property(x => x.Bord060).HasColumnName(@"BORD060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bord070).HasColumnName(@"BORD070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bord090).HasColumnName(@"BORD090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord095).HasColumnName(@"BORD095").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bord100).HasColumnName(@"BORD100").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Bord110).HasColumnName(@"BORD110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord120).HasColumnName(@"BORD120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord130).HasColumnName(@"BORD130").HasColumnType("int").IsRequired();
            Property(x => x.Bord140).HasColumnName(@"BORD140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Bord150).HasColumnName(@"BORD150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord160).HasColumnName(@"BORD160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord170).HasColumnName(@"BORD170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord180).HasColumnName(@"BORD180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord190).HasColumnName(@"BORD190").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord200).HasColumnName(@"BORD200").HasColumnType("int").IsRequired();
            Property(x => x.Bord210).HasColumnName(@"BORD210").HasColumnType("int").IsRequired();
            Property(x => x.Bord215).HasColumnName(@"BORD215").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bord220).HasColumnName(@"BORD220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord230).HasColumnName(@"BORD230").HasColumnType("int").IsRequired();
            Property(x => x.Bord235).HasColumnName(@"BORD235").HasColumnType("int").IsRequired();
            Property(x => x.Bord240).HasColumnName(@"BORD240").HasColumnType("tinyint").IsRequired();
            Property(x => x.Bord250).HasColumnName(@"BORD250").HasColumnType("datetime").IsRequired();
            Property(x => x.Bord260).HasColumnName(@"BORD260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Bord270).HasColumnName(@"BORD270").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bord999).HasColumnName(@"BORD999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Bord105).HasColumnName(@"BORD105").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
