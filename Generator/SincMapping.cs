

namespace Generator
{

    public class SincMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sinc>
    {
        public SincMapping()
            : this("dbo")
        {
        }

        public SincMapping(string schema)
        {
            ToTable("SINC", schema);
            HasKey(x => new { x.Sinc001, x.Sinc006 });

            Property(x => x.Sinc001).HasColumnName(@"SINC001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Sinc006).HasColumnName(@"SINC006").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Sinc010).HasColumnName(@"SINC010").HasColumnType("datetime").IsRequired();
            Property(x => x.Sinc020).HasColumnName(@"SINC020").HasColumnType("datetime").IsRequired();
            Property(x => x.Sinc030).HasColumnName(@"SINC030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Sinc035).HasColumnName(@"SINC035").HasColumnType("datetime").IsRequired();
            Property(x => x.Sinc040).HasColumnName(@"SINC040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Sinc050).HasColumnName(@"SINC050").HasColumnType("datetime").IsRequired();
            Property(x => x.Sinc060).HasColumnName(@"SINC060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Sinc070).HasColumnName(@"SINC070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Sinc080).HasColumnName(@"SINC080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Sinc085).HasColumnName(@"SINC085").HasColumnType("datetime").IsRequired();
            Property(x => x.Sinc090).HasColumnName(@"SINC090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Sincdtm).HasColumnName(@"SINCDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
