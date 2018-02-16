

namespace Generator
{

    public class MortMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mort>
    {
        public MortMapping()
            : this("dbo")
        {
        }

        public MortMapping(string schema)
        {
            ToTable("MORT", schema);
            HasKey(x => new { x.Mort010, x.Mort020 });

            Property(x => x.Mort010).HasColumnName(@"MORT010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mort020).HasColumnName(@"MORT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mort030).HasColumnName(@"MORT030").HasColumnType("int").IsRequired();
            Property(x => x.Mort040).HasColumnName(@"MORT040").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
        }
    }

}
