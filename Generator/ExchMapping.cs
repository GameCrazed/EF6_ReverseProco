

namespace Generator
{

    public class ExchMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Exch>
    {
        public ExchMapping()
            : this("dbo")
        {
        }

        public ExchMapping(string schema)
        {
            ToTable("EXCH", schema);
            HasKey(x => new { x.Exch020, x.Exch030, x.Exch040, x.Exch050 });

            Property(x => x.Exch020).HasColumnName(@"EXCH020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Exch030).HasColumnName(@"EXCH030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Exch040).HasColumnName(@"EXCH040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Exch050).HasColumnName(@"EXCH050").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Exch060).HasColumnName(@"EXCH060").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Exch080).HasColumnName(@"EXCH080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Exchdtm).HasColumnName(@"EXCHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Exch090).HasColumnName(@"EXCH090").HasColumnType("datetime").IsRequired();
        }
    }

}
