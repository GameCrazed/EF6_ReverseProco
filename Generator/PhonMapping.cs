

namespace Generator
{

    public class PhonMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Phon>
    {
        public PhonMapping()
            : this("dbo")
        {
        }

        public PhonMapping(string schema)
        {
            ToTable("PHON", schema);
            HasKey(x => x.Phon000);

            Property(x => x.Phon000).HasColumnName(@"PHON000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Phon001).HasColumnName(@"PHON001").HasColumnType("int").IsRequired();
            Property(x => x.Phon005).HasColumnName(@"PHON005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Phon015).HasColumnName(@"PHON015").HasColumnType("int").IsRequired();
            Property(x => x.Phon025).HasColumnName(@"PHON025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Phon020).HasColumnName(@"PHON020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Phondtm).HasColumnName(@"PHONDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Phon030).HasColumnName(@"PHON030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Phon040).HasColumnName(@"PHON040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phon050).HasColumnName(@"PHON050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phon060).HasColumnName(@"PHON060").HasColumnType("datetime").IsRequired();
            Property(x => x.Phon055).HasColumnName(@"PHON055").HasColumnType("tinyint").IsRequired();
            Property(x => x.Phon110).HasColumnName(@"PHON110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
        }
    }

}
