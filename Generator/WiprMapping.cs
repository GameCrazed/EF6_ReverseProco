

namespace Generator
{

    public class WiprMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Wipr>
    {
        public WiprMapping()
            : this("dbo")
        {
        }

        public WiprMapping(string schema)
        {
            ToTable("WIPR", schema);
            HasKey(x => new { x.Wipr001, x.Wipr005 });

            Property(x => x.Wipr001).HasColumnName(@"WIPR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Wipr005).HasColumnName(@"WIPR005").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Wipr100).HasColumnName(@"WIPR100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Wipr110).HasColumnName(@"WIPR110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Wipr120).HasColumnName(@"WIPR120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Wipr130).HasColumnName(@"WIPR130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Wipr140).HasColumnName(@"WIPR140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Wipr150).HasColumnName(@"WIPR150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Wiprdtm).HasColumnName(@"WIPRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
