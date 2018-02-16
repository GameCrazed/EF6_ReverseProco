

namespace Generator
{

    public class ChklMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Chkl>
    {
        public ChklMapping()
            : this("dbo")
        {
        }

        public ChklMapping(string schema)
        {
            ToTable("CHKL", schema);
            HasKey(x => x.Chkl001);

            Property(x => x.Chkl001).HasColumnName(@"CHKL001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Chkl005).HasColumnName(@"CHKL005").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl010).HasColumnName(@"CHKL010").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl020).HasColumnName(@"CHKL020").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl025).HasColumnName(@"CHKL025").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl027).HasColumnName(@"CHKL027").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Chkl030).HasColumnName(@"CHKL030").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl035).HasColumnName(@"CHKL035").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Chkl040).HasColumnName(@"CHKL040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl045).HasColumnName(@"CHKL045").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl050).HasColumnName(@"CHKL050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl055).HasColumnName(@"CHKL055").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl060).HasColumnName(@"CHKL060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl065).HasColumnName(@"CHKL065").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Chkl070).HasColumnName(@"CHKL070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl075).HasColumnName(@"CHKL075").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Chkl080).HasColumnName(@"CHKL080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl090).HasColumnName(@"CHKL090").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl100).HasColumnName(@"CHKL100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl110).HasColumnName(@"CHKL110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Chkl120).HasColumnName(@"CHKL120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Chkldtm).HasColumnName(@"CHKLDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
