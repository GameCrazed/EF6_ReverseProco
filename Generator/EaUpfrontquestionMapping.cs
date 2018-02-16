

namespace Generator
{

    public class EaUpfrontquestionMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaUpfrontquestion>
    {
        public EaUpfrontquestionMapping()
            : this("dbo")
        {
        }

        public EaUpfrontquestionMapping(string schema)
        {
            ToTable("ea_upfrontquestion", schema);
            HasKey(x => x.UpFrontQuestionId);

            Property(x => x.UpFrontQuestionId).HasColumnName(@"UpFrontQuestionID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DateFrom).HasColumnName(@"DateFrom").HasColumnType("datetime").IsRequired();
            Property(x => x.QuestionOrder).HasColumnName(@"QuestionOrder").HasColumnType("int").IsRequired();
            Property(x => x.Division).HasColumnName(@"Division").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2);
            Property(x => x.DateExpired).HasColumnName(@"DateExpired").HasColumnType("datetime").IsRequired();
            Property(x => x.Question).HasColumnName(@"Question").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Answer).HasColumnName(@"Answer").HasColumnType("tinyint").IsRequired();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.LoanType).HasColumnName(@"loanType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
        }
    }

}
