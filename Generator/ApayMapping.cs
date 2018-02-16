

namespace Generator
{

    public class ApayMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Apay>
    {
        public ApayMapping()
            : this("dbo")
        {
        }

        public ApayMapping(string schema)
        {
            ToTable("APAY", schema);
            HasKey(x => x.Apay000);

            Property(x => x.Apay000).HasColumnName(@"APAY000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Apay010).HasColumnName(@"APAY010").HasColumnType("int").IsRequired();
            Property(x => x.Apay015).HasColumnName(@"APAY015").HasColumnType("smallint").IsRequired();
            Property(x => x.Apay020).HasColumnName(@"APAY020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Apay040).HasColumnName(@"APAY040").HasColumnType("datetime").IsRequired();
            Property(x => x.Apay060).HasColumnName(@"APAY060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Apay070).HasColumnName(@"APAY070").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
