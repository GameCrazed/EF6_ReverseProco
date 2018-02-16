

namespace Generator
{

    public class ProductNameMapDeprecatedMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductNameMapDeprecated>
    {
        public ProductNameMapDeprecatedMapping()
            : this("dbo")
        {
        }

        public ProductNameMapDeprecatedMapping(string schema)
        {
            ToTable("productNameMapDeprecated", schema);
            HasKey(x => x.TableId);

            Property(x => x.TableId).HasColumnName(@"tableID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Productcode).HasColumnName(@"productcode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Productname).HasColumnName(@"productname").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.FriendlyName).HasColumnName(@"friendlyName").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
        }
    }

}
