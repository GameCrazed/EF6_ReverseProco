

namespace Generator
{

    public class EaAddresshistoryMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EaAddresshistory>
    {
        public EaAddresshistoryMapping()
            : this("dbo")
        {
        }

        public EaAddresshistoryMapping(string schema)
        {
            ToTable("ea_addresshistory", schema);
            HasKey(x => x.PreviousAddressId);

            Property(x => x.PreviousAddressId).HasColumnName(@"PreviousAddressID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplicantId).HasColumnName(@"ApplicantID").HasColumnType("int").IsRequired();
            Property(x => x.AddressId).HasColumnName(@"AddressID").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45);
            Property(x => x.FromDate).HasColumnName(@"FromDate").HasColumnType("datetime").IsRequired();
        }
    }

}
