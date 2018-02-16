

namespace Generator
{

    public class MostRecentCaseStateHistoryMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MostRecentCaseStateHistory>
    {
        public MostRecentCaseStateHistoryMapping()
            : this("dbo")
        {
        }

        public MostRecentCaseStateHistoryMapping(string schema)
        {
            ToTable("MostRecentCaseStateHistory", schema);
            HasKey(x => new { x.KfiId, x.CaseStateId, x.Created });

            Property(x => x.KfiId).HasColumnName(@"KfiId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CaseStateId).HasColumnName(@"CaseStateId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Created).HasColumnName(@"Created").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsOptional();
        }
    }

}
