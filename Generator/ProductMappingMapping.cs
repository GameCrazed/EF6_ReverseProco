

namespace Generator
{

    public class ProductMappingMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductMapping>
    {
        public ProductMappingMapping()
            : this("dbo")
        {
        }

        public ProductMappingMapping(string schema)
        {
            ToTable("ProductMapping", schema);
            HasKey(x => x.SourceAccountNumber);

            Property(x => x.SourceAccountNumber).HasColumnName(@"SourceAccountNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PhoebusProductNumber).HasColumnName(@"PhoebusProductNumber").HasColumnType("int").IsOptional();
            Property(x => x.PhoebusProductDescription).HasColumnName(@"PhoebusProductDescription").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2000);
            Property(x => x.ContractInterestType).HasColumnName(@"ContractInterestType").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.AccrualHistoryInterestType).HasColumnName(@"AccrualHistoryInterestType").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.InstalmentsInAdvance).HasColumnName(@"InstalmentsInAdvance").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.ContractMargin).HasColumnName(@"contractMargin").HasColumnType("decimal").IsOptional().HasPrecision(9,6);
        }
    }

}
