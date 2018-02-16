

namespace Generator
{

    public class FriendlyNameMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FriendlyName>
    {
        public FriendlyNameMapping()
            : this("dbo")
        {
        }

        public FriendlyNameMapping(string schema)
        {
            ToTable("FriendlyNames", schema);
            HasKey(x => x.FriendlyNameId);

            Property(x => x.FriendlyNameId).HasColumnName(@"FriendlyNameId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FriendlyNameText).HasColumnName(@"FriendlyNameText").HasColumnType("nvarchar(max)").IsOptional();
        }
    }

}
