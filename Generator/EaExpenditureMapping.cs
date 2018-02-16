

namespace Generator
{

    public class EaExpenditureMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaExpenditure>
    {
        public EaExpenditureMapping()
            : this("dbo")
        {
        }

        public EaExpenditureMapping(string schema)
        {
            ToTable("ea_expenditure", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicantId).HasColumnName(@"ApplicantID").HasColumnType("int").IsRequired();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Amount).HasColumnName(@"Amount").HasColumnType("float").IsRequired();
            Property(x => x.Balance).HasColumnName(@"Balance").HasColumnType("float").IsRequired();
            Property(x => x.Lender).HasColumnName(@"Lender").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Less6Months).HasColumnName(@"Less6Months").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ordinal).HasColumnName(@"Ordinal").HasColumnType("int").IsRequired();
        }
    }

}
