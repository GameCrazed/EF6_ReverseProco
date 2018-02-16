

namespace Generator
{

    public class RtchMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rtch>
    {
        public RtchMapping()
            : this("dbo")
        {
        }

        public RtchMapping(string schema)
        {
            ToTable("RTCH", schema);
            HasKey(x => new { x.Rtch010, x.Rtch020 });

            Property(x => x.Rtch010).HasColumnName(@"RTCH010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rtch020).HasColumnName(@"RTCH020").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rtch030).HasColumnName(@"RTCH030").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Rtch040).HasColumnName(@"RTCH040").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Rtch050).HasColumnName(@"RTCH050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Rtchdtm).HasColumnName(@"RTCHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
