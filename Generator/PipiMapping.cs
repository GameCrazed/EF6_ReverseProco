

namespace Generator
{

    public class PipiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pipi>
    {
        public PipiMapping()
            : this("dbo")
        {
        }

        public PipiMapping(string schema)
        {
            ToTable("PIPI", schema);
            HasKey(x => new { x.Pipi001, x.Pipi005 });

            Property(x => x.Pipi001).HasColumnName(@"PIPI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pipi005).HasColumnName(@"PIPI005").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pipi010).HasColumnName(@"PIPI010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Pipi020).HasColumnName(@"PIPI020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pipi030).HasColumnName(@"PIPI030").HasColumnType("datetime").IsRequired();
            Property(x => x.Pipi040).HasColumnName(@"PIPI040").HasColumnType("datetime").IsRequired();
            Property(x => x.Pipi050).HasColumnName(@"PIPI050").HasColumnType("datetime").IsRequired();
            Property(x => x.Pipi070).HasColumnName(@"PIPI070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pipi075).HasColumnName(@"PIPI075").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pipi080).HasColumnName(@"PIPI080").HasColumnType("datetime").IsRequired();
            Property(x => x.Pipi090).HasColumnName(@"PIPI090").HasColumnType("datetime").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pipidtm).HasColumnName(@"PIPIDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
