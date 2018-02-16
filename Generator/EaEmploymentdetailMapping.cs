

namespace Generator
{

    public class EaEmploymentdetailMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaEmploymentdetail>
    {
        public EaEmploymentdetailMapping()
            : this("dbo")
        {
        }

        public EaEmploymentdetailMapping(string schema)
        {
            ToTable("ea_employmentdetails", schema);
            HasKey(x => x.EmploymentDetailsId);

            Property(x => x.EmploymentDetailsId).HasColumnName(@"EmploymentDetailsID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EmploymentAddressId).HasColumnName(@"EmploymentAddressID").HasColumnType("int").IsOptional();
            Property(x => x.AccountantAddressId).HasColumnName(@"AccountantAddressID").HasColumnType("int").IsOptional();
            Property(x => x.DirectorAddressId).HasColumnName(@"DirectorAddressID").HasColumnType("int").IsOptional();
            Property(x => x.ApplicantId).HasColumnName(@"ApplicantID").HasColumnType("int").IsRequired();
            Property(x => x.EmployerCompanyName).HasColumnName(@"EmployerCompanyName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.TypeofEmployment).HasColumnName(@"TypeofEmployment").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.OccupationType).HasColumnName(@"OccupationType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.OccupationStatus).HasColumnName(@"OccupationStatus").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.EmployedFrom).HasColumnName(@"EmployedFrom").HasColumnType("datetime").IsOptional();
            Property(x => x.EmployedTo).HasColumnName(@"EmployedTo").HasColumnType("datetime").IsOptional();
            Property(x => x.CompRegNo).HasColumnName(@"CompRegNo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ShareHolding).HasColumnName(@"ShareHolding").HasColumnType("int").IsOptional();
            Property(x => x.Ordinal).HasColumnName(@"Ordinal").HasColumnType("int").IsRequired();
        }
    }

}
