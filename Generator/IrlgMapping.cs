

namespace Generator
{

    public class IrlgMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Irlg>
    {
        public IrlgMapping()
            : this("dbo")
        {
        }

        public IrlgMapping(string schema)
        {
            ToTable("IRLG", schema);
            HasKey(x => x.Irlg010);

            Property(x => x.Irlg010).HasColumnName(@"IRLG010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Irlg020).HasColumnName(@"IRLG020").HasColumnType("datetime").IsRequired();
            Property(x => x.Irlg030).HasColumnName(@"IRLG030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Irlg040).HasColumnName(@"IRLG040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Irlg050).HasColumnName(@"IRLG050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Irlg060).HasColumnName(@"IRLG060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Irlg070).HasColumnName(@"IRLG070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Irlgdtm).HasColumnName(@"IRLGDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
