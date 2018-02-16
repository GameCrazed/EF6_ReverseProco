

namespace Generator
{

    public class RednMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Redn>
    {
        public RednMapping()
            : this("dbo")
        {
        }

        public RednMapping(string schema)
        {
            ToTable("REDN", schema);
            HasKey(x => x.Redn001);

            Property(x => x.Redn001).HasColumnName(@"REDN001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Redn010).HasColumnName(@"REDN010").HasColumnType("datetime").IsRequired();
            Property(x => x.Redn020).HasColumnName(@"REDN020").HasColumnType("int").IsRequired();
            Property(x => x.Redn030).HasColumnName(@"REDN030").HasColumnType("datetime").IsRequired();
            Property(x => x.Redn040).HasColumnName(@"REDN040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redn050).HasColumnName(@"REDN050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redn060).HasColumnName(@"REDN060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redn070).HasColumnName(@"REDN070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redn080).HasColumnName(@"REDN080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Redndtm).HasColumnName(@"REDNDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
