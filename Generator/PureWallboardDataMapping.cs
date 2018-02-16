

namespace Generator
{

    public class PureWallboardDataMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PureWallboardData>
    {
        public PureWallboardDataMapping()
            : this("dbo")
        {
        }

        public PureWallboardDataMapping(string schema)
        {
            ToTable("pureWallboardData", schema);
            HasKey(x => x.Desc);

            Property(x => x.ReportNo).HasColumnName(@"reportNo").HasColumnType("int").IsOptional();
            Property(x => x.Desc).HasColumnName(@"desc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
