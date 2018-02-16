

namespace Generator
{

    public class BenchmarkPenaltyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BenchmarkPenalty>
    {
        public BenchmarkPenaltyMapping()
            : this("dbo")
        {
        }

        public BenchmarkPenaltyMapping(string schema)
        {
            ToTable("Benchmark Penalties", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Age).HasColumnName(@"Age").HasColumnType("float").IsOptional();
            Property(x => x.ProductCode).HasColumnName(@"ProductCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.SingleJoint).HasColumnName(@"SingleJoint").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Ltv).HasColumnName(@"LTV").HasColumnType("float").IsOptional();
            Property(x => x.Uplift).HasColumnName(@"Uplift").HasColumnType("float").IsOptional();
        }
    }

}
