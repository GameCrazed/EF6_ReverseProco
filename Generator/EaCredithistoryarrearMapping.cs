

namespace Generator
{

    public class EaCredithistoryarrearMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaCredithistoryarrear>
    {
        public EaCredithistoryarrearMapping()
            : this("dbo")
        {
        }

        public EaCredithistoryarrearMapping(string schema)
        {
            ToTable("ea_credithistoryarrears", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicantId).HasColumnName(@"ApplicantID").HasColumnType("int").IsRequired();
            Property(x => x.Amount).HasColumnName(@"Amount").HasColumnType("float").IsRequired();
            Property(x => x.DateIncured).HasColumnName(@"DateIncured").HasColumnType("datetime").IsOptional();
            Property(x => x.LoanType).HasColumnName(@"LoanType").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
        }
    }

}
