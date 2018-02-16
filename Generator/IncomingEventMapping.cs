

namespace Generator
{

    public class IncomingEventMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<IncomingEvent>
    {
        public IncomingEventMapping()
            : this("dbo")
        {
        }

        public IncomingEventMapping(string schema)
        {
            ToTable("IncomingEvent", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Event).HasColumnName(@"event").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PhoebusJobCode).HasColumnName(@"phoebusJobCode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Description).HasColumnName(@"description").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
        }
    }

}
