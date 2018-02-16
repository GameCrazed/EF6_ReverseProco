

namespace Generator
{

    public class GushResultMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GushResult>
    {
        public GushResultMapping()
            : this("dbo")
        {
        }

        public GushResultMapping(string schema)
        {
            ToTable("GushResults", schema);
            HasKey(x => x.GushId);

            Property(x => x.GushId).HasColumnName(@"GushId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Value).HasColumnName(@"Value").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.Comment).HasColumnName(@"Comment").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Gush).WithOptional(b => b.GushResult).WillCascadeOnDelete(false);
        }
    }

}
