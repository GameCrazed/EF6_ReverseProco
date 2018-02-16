

namespace Generator
{

    public class DepxMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Depx>
    {
        public DepxMapping()
            : this("dbo")
        {
        }

        public DepxMapping(string schema)
        {
            ToTable("DEPX", schema);
            HasKey(x => new { x.Depx010, x.Depx003 });

            Property(x => x.Depx003).HasColumnName(@"DEPX003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Depx010).HasColumnName(@"DEPX010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Depx030).HasColumnName(@"DEPX030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Depx150).HasColumnName(@"DEPX150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Depx160).HasColumnName(@"DEPX160").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Depx170).HasColumnName(@"DEPX170").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Depx180).HasColumnName(@"DEPX180").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Depx999).HasColumnName(@"DEPX999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Depx040).HasColumnName(@"DEPX040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Depx190).HasColumnName(@"DEPX190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
