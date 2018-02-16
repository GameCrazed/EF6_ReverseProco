

namespace Generator
{

    public class CondMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cond>
    {
        public CondMapping()
            : this("dbo")
        {
        }

        public CondMapping(string schema)
        {
            ToTable("COND", schema);
            HasKey(x => x.Cond000);

            Property(x => x.Cond001).HasColumnName(@"COND001").HasColumnType("int").IsRequired();
            Property(x => x.Cond005).HasColumnName(@"COND005").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cond007).HasColumnName(@"COND007").HasColumnType("int").IsRequired();
            Property(x => x.Cond020).HasColumnName(@"COND020").HasColumnType("int").IsRequired();
            Property(x => x.Cond030).HasColumnName(@"COND030").HasColumnType("smallint").IsRequired();
            Property(x => x.Cond040).HasColumnName(@"COND040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cond090).HasColumnName(@"COND090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cond100).HasColumnName(@"COND100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Cond200).HasColumnName(@"COND200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Cond210).HasColumnName(@"COND210").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cond600).HasColumnName(@"COND600").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Cond610).HasColumnName(@"COND610").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cond050).HasColumnName(@"COND050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Cond000).HasColumnName(@"COND000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
