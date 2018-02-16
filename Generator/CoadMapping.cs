

namespace Generator
{

    public class CoadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Coad>
    {
        public CoadMapping()
            : this("dbo")
        {
        }

        public CoadMapping(string schema)
        {
            ToTable("COAD", schema);
            HasKey(x => x.Coad001);

            Property(x => x.Coad001).HasColumnName(@"COAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Coad100).HasColumnName(@"COAD100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Coad102).HasColumnName(@"COAD102").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Coad104).HasColumnName(@"COAD104").HasColumnType("datetime").IsRequired();
            Property(x => x.Coad110).HasColumnName(@"COAD110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Coad112).HasColumnName(@"COAD112").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Coad114).HasColumnName(@"COAD114").HasColumnType("datetime").IsRequired();
            Property(x => x.Coad120).HasColumnName(@"COAD120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Coad122).HasColumnName(@"COAD122").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Coad124).HasColumnName(@"COAD124").HasColumnType("datetime").IsRequired();
            Property(x => x.Coad130).HasColumnName(@"COAD130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Coad132).HasColumnName(@"COAD132").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Coad134).HasColumnName(@"COAD134").HasColumnType("datetime").IsRequired();
            Property(x => x.Coad140).HasColumnName(@"COAD140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Coad142).HasColumnName(@"COAD142").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.Coad144).HasColumnName(@"COAD144").HasColumnType("datetime").IsRequired();
            Property(x => x.Coad500).HasColumnName(@"COAD500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
        }
    }

}
