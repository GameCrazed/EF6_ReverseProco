

namespace Generator
{

    public class HelpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Help>
    {
        public HelpMapping()
            : this("dbo")
        {
        }

        public HelpMapping(string schema)
        {
            ToTable("HELP", schema);
            HasKey(x => x.Help010);

            Property(x => x.Help010).HasColumnName(@"HELP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Help030).HasColumnName(@"HELP030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Help040).HasColumnName(@"HELP040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Help0501).HasColumnName(@"HELP0501").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Help0502).HasColumnName(@"HELP0502").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Help0503).HasColumnName(@"HELP0503").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Help0504).HasColumnName(@"HELP0504").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Help090).HasColumnName(@"HELP090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Help1001).HasColumnName(@"HELP1001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Help1002).HasColumnName(@"HELP1002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Help1003).HasColumnName(@"HELP1003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Help1004).HasColumnName(@"HELP1004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Help110).HasColumnName(@"HELP110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Help020).HasColumnName(@"HELP020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0601).HasColumnName(@"HELP0601").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0602).HasColumnName(@"HELP0602").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0603).HasColumnName(@"HELP0603").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0604).HasColumnName(@"HELP0604").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0605).HasColumnName(@"HELP0605").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0701).HasColumnName(@"HELP0701").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0702).HasColumnName(@"HELP0702").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0703).HasColumnName(@"HELP0703").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0704).HasColumnName(@"HELP0704").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Help0705).HasColumnName(@"HELP0705").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Helpdtm).HasColumnName(@"HELPDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
