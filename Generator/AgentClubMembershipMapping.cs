

namespace Generator
{

    public class AgentClubMembershipMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AgentClubMembership>
    {
        public AgentClubMembershipMapping()
            : this("dbo")
        {
        }

        public AgentClubMembershipMapping(string schema)
        {
            ToTable("AgentClubMemberships", schema);
            HasKey(x => new { x.PhoebusContactId, x.BrokerClubId });

            Property(x => x.PhoebusContactId).HasColumnName(@"PhoebusContactId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BrokerClubId).HasColumnName(@"BrokerClubId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.BrokerClub).WithMany(b => b.AgentClubMemberships).HasForeignKey(c => c.BrokerClubId);
        }
    }

}
