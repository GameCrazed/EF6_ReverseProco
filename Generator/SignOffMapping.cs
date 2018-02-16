

namespace Generator
{

    public class SignOffMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SignOff>
    {
        public SignOffMapping()
            : this("dbo")
        {
        }

        public SignOffMapping(string schema)
        {
            ToTable("SignOffs", schema);
            HasKey(x => x.SignOffId);

            Property(x => x.SignOffId).HasColumnName(@"SignOffId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar(max)").IsOptional();
        }
    }

}
