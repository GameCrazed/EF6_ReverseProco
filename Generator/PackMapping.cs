

namespace Generator
{

    public class PackMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pack>
    {
        public PackMapping()
            : this("dbo")
        {
        }

        public PackMapping(string schema)
        {
            ToTable("Packs", schema);
            HasKey(x => x.PackId);

            Property(x => x.PackId).HasColumnName(@"PackId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Created).HasColumnName(@"Created").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsOptional();
        }
    }

}
