

namespace Generator
{

    public class UcstMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ucst>
    {
        public UcstMapping()
            : this("dbo")
        {
        }

        public UcstMapping(string schema)
        {
            ToTable("UCST", schema);
            HasKey(x => x.Ucst010);

            Property(x => x.Ucst010).HasColumnName(@"UCST010").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ucst015).HasColumnName(@"UCST015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Ucst020).HasColumnName(@"UCST020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Ucst060).HasColumnName(@"UCST060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ucst070).HasColumnName(@"UCST070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
