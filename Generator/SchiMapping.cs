

namespace Generator
{

    public class SchiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Schi>
    {
        public SchiMapping()
            : this("dbo")
        {
        }

        public SchiMapping(string schema)
        {
            ToTable("SCHI", schema);
            HasKey(x => x.Schi001);

            Property(x => x.Schi001).HasColumnName(@"SCHI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Schi010).HasColumnName(@"SCHI010").HasColumnType("datetime").IsRequired();
            Property(x => x.Schi015).HasColumnName(@"SCHI015").HasColumnType("smallint").IsRequired();
            Property(x => x.Schi020).HasColumnName(@"SCHI020").HasColumnType("smallint").IsRequired();
            Property(x => x.Schi025).HasColumnName(@"SCHI025").HasColumnType("smallint").IsRequired();
            Property(x => x.Schi030).HasColumnName(@"SCHI030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
        }
    }

}
