

namespace Generator
{

    public class EaExistingloanMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaExistingloan>
    {
        public EaExistingloanMapping()
            : this("dbo")
        {
        }

        public EaExistingloanMapping(string schema)
        {
            ToTable("ea_existingloan", schema);
            HasKey(x => x.ExistingLoanId);

            Property(x => x.ExistingLoanId).HasColumnName(@"ExistingLoanId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicationId).HasColumnName(@"ApplicationId").HasColumnType("int").IsRequired();
            Property(x => x.AddressId).HasColumnName(@"AddressId").HasColumnType("int").IsRequired();
            Property(x => x.Lender).HasColumnName(@"Lender").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Reference).HasColumnName(@"Reference").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Payment).HasColumnName(@"Payment").HasColumnType("float").IsRequired();
            Property(x => x.Balance).HasColumnName(@"Balance").HasColumnType("float").IsRequired();
            Property(x => x.Priority).HasColumnName(@"Priority").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Ordinal).HasColumnName(@"Ordinal").HasColumnType("int").IsRequired();
        }
    }

}
