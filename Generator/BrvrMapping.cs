

namespace Generator
{

    public class BrvrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Brvr>
    {
        public BrvrMapping()
            : this("dbo")
        {
        }

        public BrvrMapping(string schema)
        {
            ToTable("BRVR", schema);
            HasKey(x => new { x.Brvr020, x.Brvr030 });

            Property(x => x.Brvr020).HasColumnName(@"BRVR020").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Brvr030).HasColumnName(@"BRVR030").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Brvr040).HasColumnName(@"BRVR040").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Brvr050).HasColumnName(@"BRVR050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Brvr060).HasColumnName(@"BRVR060").HasColumnType("datetime").IsRequired();
            Property(x => x.Brvrdtm).HasColumnName(@"BRVRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
