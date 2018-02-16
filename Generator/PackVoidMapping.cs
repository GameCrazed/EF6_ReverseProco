

namespace Generator
{

    public class PackVoidMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PackVoid>
    {
        public PackVoidMapping()
            : this("dbo")
        {
        }

        public PackVoidMapping(string schema)
        {
            ToTable("PackVoids", schema);
            HasKey(x => x.PackId);

            Property(x => x.Created).HasColumnName(@"Created").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PackId).HasColumnName(@"PackId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Reason).HasColumnName(@"Reason").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.Pack).WithOptional(b => b.PackVoid).WillCascadeOnDelete(false);
        }
    }

}
