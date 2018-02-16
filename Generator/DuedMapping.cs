

namespace Generator
{

    public class DuedMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Dued>
    {
        public DuedMapping()
            : this("dbo")
        {
        }

        public DuedMapping(string schema)
        {
            ToTable("DUED", schema);
            HasKey(x => x.Dued999);

            Property(x => x.Dued010).HasColumnName(@"DUED010").HasColumnType("datetime").IsRequired();
            Property(x => x.Dued020).HasColumnName(@"DUED020").HasColumnType("int").IsRequired();
            Property(x => x.Dued030).HasColumnName(@"DUED030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dued035).HasColumnName(@"DUED035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dued037).HasColumnName(@"DUED037").HasColumnType("int").IsRequired();
            Property(x => x.Dued040).HasColumnName(@"DUED040").HasColumnType("datetime").IsRequired();
            Property(x => x.Dued050).HasColumnName(@"DUED050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dued060).HasColumnName(@"DUED060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dued070).HasColumnName(@"DUED070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Dued085).HasColumnName(@"DUED085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dued150).HasColumnName(@"DUED150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Dued200).HasColumnName(@"DUED200").HasColumnType("int").IsRequired();
            Property(x => x.Dued300).HasColumnName(@"DUED300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Dued310).HasColumnName(@"DUED310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Dued320).HasColumnName(@"DUED320").HasColumnType("datetime").IsRequired();
            Property(x => x.Dued330).HasColumnName(@"DUED330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dued400).HasColumnName(@"DUED400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Dued999).HasColumnName(@"DUED999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Dued063).HasColumnName(@"DUED063").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dued065).HasColumnName(@"DUED065").HasColumnType("tinyint").IsRequired();
        }
    }

}
