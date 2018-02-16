

namespace Generator
{

    public class EaCredithistoryccjMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaCredithistoryccj>
    {
        public EaCredithistoryccjMapping()
            : this("dbo")
        {
        }

        public EaCredithistoryccjMapping(string schema)
        {
            ToTable("ea_credithistoryccj", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicantId).HasColumnName(@"ApplicantID").HasColumnType("int").IsRequired();
            Property(x => x.Reference).HasColumnName(@"Reference").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Value).HasColumnName(@"Value").HasColumnType("float").IsOptional();
            Property(x => x.DateIssued).HasColumnName(@"DateIssued").HasColumnType("datetime").IsOptional();
            Property(x => x.DateCleared).HasColumnName(@"DateCleared").HasColumnType("datetime").IsOptional();
        }
    }

}
