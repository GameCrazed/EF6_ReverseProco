

namespace Generator
{

    public class WfopMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Wfop>
    {
        public WfopMapping()
            : this("dbo")
        {
        }

        public WfopMapping(string schema)
        {
            ToTable("WFOP", schema);
            HasKey(x => x.Wfop999);

            Property(x => x.Wfop010).HasColumnName(@"WFOP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfop020).HasColumnName(@"WFOP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Wfop030).HasColumnName(@"WFOP030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Wfop040).HasColumnName(@"WFOP040").HasColumnType("int").IsRequired();
            Property(x => x.Wfop050).HasColumnName(@"WFOP050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Wfop060).HasColumnName(@"WFOP060").HasColumnType("smallint").IsRequired();
            Property(x => x.Wfop999).HasColumnName(@"WFOP999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Wfop045).HasColumnName(@"WFOP045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfop070).HasColumnName(@"WFOP070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfop075).HasColumnName(@"WFOP075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
