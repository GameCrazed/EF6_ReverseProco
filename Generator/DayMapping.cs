

namespace Generator
{

    public class DayMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Day>
    {
        public DayMapping()
            : this("dbo")
        {
        }

        public DayMapping(string schema)
        {
            ToTable("DAYS", schema);
            HasKey(x => new { x.Days010, x.Days020, x.Days030 });

            Property(x => x.Days010).HasColumnName(@"DAYS010").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Days020).HasColumnName(@"DAYS020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Days030).HasColumnName(@"DAYS030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Daysdtm).HasColumnName(@"DAYSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
