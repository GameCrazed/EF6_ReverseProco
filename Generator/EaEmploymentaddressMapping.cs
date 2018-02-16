

namespace Generator
{

    public class EaEmploymentaddressMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaEmploymentaddress>
    {
        public EaEmploymentaddressMapping()
            : this("dbo")
        {
        }

        public EaEmploymentaddressMapping(string schema)
        {
            ToTable("ea_employmentaddress", schema);
            HasKey(x => x.EmploymentAddressId);

            Property(x => x.EmploymentAddressId).HasColumnName(@"EmploymentAddressID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.AddressId).HasColumnName(@"AddressID").HasColumnType("int").IsOptional();
            Property(x => x.ContactName).HasColumnName(@"ContactName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Positions).HasColumnName(@"Positions").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ContactNumberStd).HasColumnName(@"ContactNumberSTD").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.ContactNumber).HasColumnName(@"ContactNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.PhoneType).HasColumnName(@"PhoneType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FaxNumber).HasColumnName(@"FaxNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.EmailAddress).HasColumnName(@"EmailAddress").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Qualifications).HasColumnName(@"Qualifications").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(45);
        }
    }

}
