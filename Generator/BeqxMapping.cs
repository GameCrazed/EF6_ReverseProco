

namespace Generator
{

    public class BeqxMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Beqx>
    {
        public BeqxMapping()
            : this("dbo")
        {
        }

        public BeqxMapping(string schema)
        {
            ToTable("BEQX", schema);
            HasKey(x => x.Beqx001);

            Property(x => x.Beqx001).HasColumnName(@"BEQX001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Beqx005).HasColumnName(@"BEQX005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Beqx010).HasColumnName(@"BEQX010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Beqx015).HasColumnName(@"BEQX015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Beqx020).HasColumnName(@"BEQX020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Beqx030).HasColumnName(@"BEQX030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Beqx040).HasColumnName(@"BEQX040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Beqx060).HasColumnName(@"BEQX060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Beqx100).HasColumnName(@"BEQX100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Beqx110).HasColumnName(@"BEQX110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Beqx120).HasColumnName(@"BEQX120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Beqx900).HasColumnName(@"BEQX900").HasColumnType("int").IsRequired();
            Property(x => x.Beqx130).HasColumnName(@"BEQX130").HasColumnType("int").IsRequired();
            Property(x => x.Beqx140).HasColumnName(@"BEQX140").HasColumnType("datetime").IsRequired();
        }
    }

}
