

namespace Generator
{

    public class PoolMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pool>
    {
        public PoolMapping()
            : this("dbo")
        {
        }

        public PoolMapping(string schema)
        {
            ToTable("POOL", schema);
            HasKey(x => x.Pool010);

            Property(x => x.Pool010).HasColumnName(@"POOL010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pool020).HasColumnName(@"POOL020").HasColumnType("int").IsRequired();
            Property(x => x.Pool030).HasColumnName(@"POOL030").HasColumnType("int").IsRequired();
            Property(x => x.Pool040).HasColumnName(@"POOL040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pool050).HasColumnName(@"POOL050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Pool060).HasColumnName(@"POOL060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pool070).HasColumnName(@"POOL070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Pool080).HasColumnName(@"POOL080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pool090).HasColumnName(@"POOL090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Pool100).HasColumnName(@"POOL100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pool110).HasColumnName(@"POOL110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Pool120).HasColumnName(@"POOL120").HasColumnType("datetime").IsRequired();
            Property(x => x.Pool130).HasColumnName(@"POOL130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Pool260).HasColumnName(@"POOL260").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pool270).HasColumnName(@"POOL270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pool280).HasColumnName(@"POOL280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
        }
    }

}
