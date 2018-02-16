

namespace Generator
{

    public class NbbiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbbi>
    {
        public NbbiMapping()
            : this("dbo")
        {
        }

        public NbbiMapping(string schema)
        {
            ToTable("NBBI", schema);
            HasKey(x => x.Nbbi001);

            Property(x => x.Nbbi001).HasColumnName(@"NBBI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbbi002).HasColumnName(@"NBBI002").HasColumnType("int").IsRequired();
            Property(x => x.Nbbi010).HasColumnName(@"NBBI010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Nbbi020).HasColumnName(@"NBBI020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbbi030).HasColumnName(@"NBBI030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbbi040).HasColumnName(@"NBBI040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbbi050).HasColumnName(@"NBBI050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbbi060).HasColumnName(@"NBBI060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(11);
            Property(x => x.Nbbi070).HasColumnName(@"NBBI070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbbi080).HasColumnName(@"NBBI080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Nbbi090).HasColumnName(@"NBBI090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Nbbi100).HasColumnName(@"NBBI100").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbbi110).HasColumnName(@"NBBI110").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbbi120).HasColumnName(@"NBBI120").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbbi130).HasColumnName(@"NBBI130").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbbi200).HasColumnName(@"NBBI200").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbbi210).HasColumnName(@"NBBI210").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbbi220).HasColumnName(@"NBBI220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbbi230).HasColumnName(@"NBBI230").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbbi240).HasColumnName(@"NBBI240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbbi250).HasColumnName(@"NBBI250").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Nbbi260).HasColumnName(@"NBBI260").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbbi270).HasColumnName(@"NBBI270").HasColumnType("int").IsRequired();
            Property(x => x.Nbbi280).HasColumnName(@"NBBI280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbbi290).HasColumnName(@"NBBI290").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Nbbi300).HasColumnName(@"NBBI300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbbi310).HasColumnName(@"NBBI310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbbi999).HasColumnName(@"NBBI999").HasColumnType("int").IsRequired();
        }
    }

}
