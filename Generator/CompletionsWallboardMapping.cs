

namespace Generator
{

    public class CompletionsWallboardMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CompletionsWallboard>
    {
        public CompletionsWallboardMapping()
            : this("dbo")
        {
        }

        public CompletionsWallboardMapping(string schema)
        {
            ToTable("CompletionsWallboard", schema);
            HasKey(x => new { x.AccountNumber, x.Customer1Surname, x.Customer2Surname, x.AnticipatedCompletionDate });

            Property(x => x.AccountNumber).HasColumnName(@"AccountNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Customer1Surname).HasColumnName(@"Customer1Surname").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Customer2Surname).HasColumnName(@"Customer2Surname").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AnticipatedCompletionDate).HasColumnName(@"AnticipatedCompletionDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CotReceived).HasColumnName(@"COTReceived").HasColumnType("bit").IsOptional();
        }
    }

}
