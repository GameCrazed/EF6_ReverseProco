

namespace Generator
{

    public class SgBrokerCommMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SgBrokerComm>
    {
        public SgBrokerCommMapping()
            : this("dbo")
        {
        }

        public SgBrokerCommMapping(string schema)
        {
            ToTable("sgBrokerComms", schema);
            HasKey(x => new { x.Type, x.NominalA47CRef, x.DepartmentCode, x.TaxCode, x.TaxAmount });

            Property(x => x.CompletionDate).HasColumnName(@"completionDate").HasColumnType("datetime").IsOptional();
            Property(x => x.BrokerFirm).HasColumnName(@"brokerFirm").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerAgent).HasColumnName(@"brokerAgent").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(101);
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AccountReference).HasColumnName(@"Account Reference").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(51);
            Property(x => x.NominalA47CRef).HasColumnName(@"Nominal A/C Ref").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DepartmentCode).HasColumnName(@"Department Code").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Date).HasColumnName(@"Date").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Reference).HasColumnName(@"Reference").HasColumnType("nvarchar").IsOptional().HasMaxLength(66);
            Property(x => x.Details).HasColumnName(@"Details").HasColumnType("nvarchar").IsOptional().HasMaxLength(242);
            Property(x => x.NetAmount).HasColumnName(@"Net Amount").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.TaxCode).HasColumnName(@"Tax Code").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TaxAmount).HasColumnName(@"Tax Amount").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
