

namespace Generator
{

    public class StffMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Stff>
    {
        public StffMapping()
            : this("dbo")
        {
        }

        public StffMapping(string schema)
        {
            ToTable("STFF", schema);
            HasKey(x => x.Stff001);

            Property(x => x.Stff001).HasColumnName(@"STFF001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Stff010).HasColumnName(@"STFF010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stff020).HasColumnName(@"STFF020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stff030).HasColumnName(@"STFF030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stff040).HasColumnName(@"STFF040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stff050).HasColumnName(@"STFF050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stff060).HasColumnName(@"STFF060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Stff070).HasColumnName(@"STFF070").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
