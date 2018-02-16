

namespace Generator
{

    public class PackVersionSignOffMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PackVersionSignOff>
    {
        public PackVersionSignOffMapping()
            : this("dbo")
        {
        }

        public PackVersionSignOffMapping(string schema)
        {
            ToTable("PackVersionSignOffs", schema);
            HasKey(x => new { x.PackId, x.VersionId, x.SignOffId });

            Property(x => x.PackId).HasColumnName(@"PackId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VersionId).HasColumnName(@"VersionId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SignOffId).HasColumnName(@"SignOffId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.PackVersion).WithMany(b => b.PackVersionSignOffs).HasForeignKey(c => new { c.PackId, c.VersionId });
            HasRequired(a => a.SignOff).WithMany(b => b.PackVersionSignOffs).HasForeignKey(c => c.SignOffId);
        }
    }

}
