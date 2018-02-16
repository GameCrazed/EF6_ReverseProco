

namespace Generator
{

    public class ProductNameMappingMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductNameMapping>
    {
        public ProductNameMappingMapping()
            : this("dbo")
        {
        }

        public ProductNameMappingMapping(string schema)
        {
            ToTable("ProductNameMappings", schema);
            HasKey(x => x.ProductCode);

            Property(x => x.ProductCode).HasColumnName(@"ProductCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FriendlyNameId).HasColumnName(@"FriendlyNameId").HasColumnType("int").IsRequired();
            Property(x => x.ProductName).HasColumnName(@"ProductName").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.FriendlyName).WithMany(b => b.ProductNameMappings).HasForeignKey(c => c.FriendlyNameId);
        }
    }

}
