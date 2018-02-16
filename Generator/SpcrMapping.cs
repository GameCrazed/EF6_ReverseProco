

namespace Generator
{

    public class SpcrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Spcr>
    {
        public SpcrMapping()
            : this("dbo")
        {
        }

        public SpcrMapping(string schema)
        {
            ToTable("SPCR", schema);
            HasKey(x => x.Spcr001);

            Property(x => x.Spcr001).HasColumnName(@"SPCR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Spcr003).HasColumnName(@"SPCR003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Spcr004).HasColumnName(@"SPCR004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Spcr010).HasColumnName(@"SPCR010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Spcr020).HasColumnName(@"SPCR020").HasColumnType("datetime").IsRequired();
            Property(x => x.Spcr030).HasColumnName(@"SPCR030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Spcr040).HasColumnName(@"SPCR040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Spcr050).HasColumnName(@"SPCR050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Spcr060).HasColumnName(@"SPCR060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Spcr070).HasColumnName(@"SPCR070").HasColumnType("int").IsRequired();
            Property(x => x.Spcr080).HasColumnName(@"SPCR080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Spcr1001).HasColumnName(@"SPCR1001").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr1002).HasColumnName(@"SPCR1002").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr1003).HasColumnName(@"SPCR1003").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr1004).HasColumnName(@"SPCR1004").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr1005).HasColumnName(@"SPCR1005").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr1006).HasColumnName(@"SPCR1006").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr1007).HasColumnName(@"SPCR1007").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr1008).HasColumnName(@"SPCR1008").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr1009).HasColumnName(@"SPCR1009").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr10010).HasColumnName(@"SPCR10010").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr10011).HasColumnName(@"SPCR10011").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr10012).HasColumnName(@"SPCR10012").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Spcr200).HasColumnName(@"SPCR200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Spcr205).HasColumnName(@"SPCR205").HasColumnType("datetime").IsRequired();
            Property(x => x.Spcr500).HasColumnName(@"SPCR500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
        }
    }

}
