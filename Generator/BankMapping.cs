

namespace Generator
{

    public class BankMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Bank>
    {
        public BankMapping()
            : this("dbo")
        {
        }

        public BankMapping(string schema)
        {
            ToTable("BANK", schema);
            HasKey(x => x.Bank030);

            Property(x => x.Bank030).HasColumnName(@"BANK030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Bank040).HasColumnName(@"BANK040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Bank0501).HasColumnName(@"BANK0501").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bank0502).HasColumnName(@"BANK0502").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bank0503).HasColumnName(@"BANK0503").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bank0504).HasColumnName(@"BANK0504").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bank0505).HasColumnName(@"BANK0505").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Bank060).HasColumnName(@"BANK060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Bank070).HasColumnName(@"BANK070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Bank080).HasColumnName(@"BANK080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Bank090).HasColumnName(@"BANK090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Bankdtm).HasColumnName(@"BANKDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Bank001).HasColumnName(@"BANK001").HasColumnType("int").IsRequired();
            Property(x => x.Bank027).HasColumnName(@"BANK027").HasColumnType("int").IsRequired();
            Property(x => x.Bank028).HasColumnName(@"BANK028").HasColumnType("datetime").IsRequired();
        }
    }

}
