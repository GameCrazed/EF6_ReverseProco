

namespace Generator
{

    public class BrclMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Brcl>
    {
        public BrclMapping()
            : this("dbo")
        {
        }

        public BrclMapping(string schema)
        {
            ToTable("BRCL", schema);
            HasKey(x => x.Brcl040);

            Property(x => x.Brcl030).HasColumnName(@"BRCL030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Brcl040).HasColumnName(@"BRCL040").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Brcl050).HasColumnName(@"BRCL050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Brcl060).HasColumnName(@"BRCL060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brcl070).HasColumnName(@"BRCL070").HasColumnType("datetime").IsRequired();
            Property(x => x.Brcl080).HasColumnName(@"BRCL080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Brcl090).HasColumnName(@"BRCL090").HasColumnType("datetime").IsRequired();
            Property(x => x.Brcl100).HasColumnName(@"BRCL100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brcl110).HasColumnName(@"BRCL110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brcl200).HasColumnName(@"BRCL200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brcl300).HasColumnName(@"BRCL300").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Brcldtm).HasColumnName(@"BRCLDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Brcl400).HasColumnName(@"BRCL400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brcl410).HasColumnName(@"BRCL410").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brcl420).HasColumnName(@"BRCL420").HasColumnType("tinyint").IsRequired();
            Property(x => x.Brcl065).HasColumnName(@"BRCL065").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Brcl051).HasColumnName(@"BRCL051").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
        }
    }

}
