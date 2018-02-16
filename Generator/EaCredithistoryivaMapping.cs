

namespace Generator
{

    public class EaCredithistoryivaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaCredithistoryiva>
    {
        public EaCredithistoryivaMapping()
            : this("dbo")
        {
        }

        public EaCredithistoryivaMapping(string schema)
        {
            ToTable("ea_credithistoryiva", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicantId).HasColumnName(@"ApplicantID").HasColumnType("int").IsRequired();
            Property(x => x.CurrentBalance).HasColumnName(@"CurrentBalance").HasColumnType("float").IsOptional();
            Property(x => x.MonthlyAmount).HasColumnName(@"MonthlyAmount").HasColumnType("float").IsOptional();
            Property(x => x.DateIncepted).HasColumnName(@"DateIncepted").HasColumnType("datetime").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.DateCleared).HasColumnName(@"DateCleared").HasColumnType("datetime").IsOptional();
        }
    }

}
