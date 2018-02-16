

namespace Generator
{

    public class PssmMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pssm>
    {
        public PssmMapping()
            : this("dbo")
        {
        }

        public PssmMapping(string schema)
        {
            ToTable("PSSM", schema);
            HasKey(x => x.Pssm001);

            Property(x => x.Pssm001).HasColumnName(@"PSSM001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pssm010).HasColumnName(@"PSSM010").HasColumnType("int").IsRequired();
            Property(x => x.Pssm015).HasColumnName(@"PSSM015").HasColumnType("int").IsRequired();
            Property(x => x.Pssm020).HasColumnName(@"PSSM020").HasColumnType("datetime").IsRequired();
            Property(x => x.Pssm030).HasColumnName(@"PSSM030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pssm040).HasColumnName(@"PSSM040").HasColumnType("int").IsRequired();
            Property(x => x.Pssm500).HasColumnName(@"PSSM500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Pssm017).HasColumnName(@"PSSM017").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pssmdtm).HasColumnName(@"PSSMDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Pssm050).HasColumnName(@"PSSM050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pssm025).HasColumnName(@"PSSM025").HasColumnType("int").IsRequired();
        }
    }

}
