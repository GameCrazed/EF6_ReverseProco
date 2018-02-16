

namespace Generator
{

    public class LencMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Lenc>
    {
        public LencMapping()
            : this("dbo")
        {
        }

        public LencMapping(string schema)
        {
            ToTable("LENC", schema);
            HasKey(x => x.Lenc999);

            Property(x => x.Lenc010).HasColumnName(@"LENC010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Lenc020).HasColumnName(@"LENC020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Lenc025).HasColumnName(@"LENC025").HasColumnType("int").IsRequired();
            Property(x => x.Lenc030).HasColumnName(@"LENC030").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Lenc040).HasColumnName(@"LENC040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Lenc050).HasColumnName(@"LENC050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Lenc100).HasColumnName(@"LENC100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Lenc300).HasColumnName(@"LENC300").HasColumnType("datetime").IsRequired();
            Property(x => x.Lenc310).HasColumnName(@"LENC310").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Lenc900).HasColumnName(@"LENC900").HasColumnType("int").IsRequired();
            Property(x => x.Lenc999).HasColumnName(@"LENC999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Lenc022).HasColumnName(@"LENC022").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Lenc026).HasColumnName(@"LENC026").HasColumnType("int").IsRequired();
            Property(x => x.Lenc060).HasColumnName(@"LENC060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Lenc070).HasColumnName(@"LENC070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Lenc080).HasColumnName(@"LENC080").HasColumnType("int").IsRequired();
            Property(x => x.Lenc075).HasColumnName(@"LENC075").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Lenc076).HasColumnName(@"LENC076").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
        }
    }

}
