

namespace Generator
{

    public class AgentMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Agent>
    {
        public AgentMapping()
            : this("dbo")
        {
        }

        public AgentMapping(string schema)
        {
            ToTable("Agents", schema);
            HasKey(x => x.PhoebusContactId);

            Property(x => x.PhoebusContactId).HasColumnName(@"PhoebusContactId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BrokerManagerId).HasColumnName(@"BrokerManagerId").HasColumnType("int").IsOptional();
            Property(x => x.IsFieldBased).HasColumnName(@"IsFieldBased").HasColumnType("bit").IsOptional();
            Property(x => x.IsAdmin).HasColumnName(@"IsAdmin").HasColumnType("bit").IsRequired();

            HasOptional(a => a.BrokerManager).WithMany(b => b.Agents).HasForeignKey(c => c.BrokerManagerId).WillCascadeOnDelete(false);
        }
    }

}
