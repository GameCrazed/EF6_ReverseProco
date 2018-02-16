

namespace Generator
{

    public class NblbMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nblb>
    {
        public NblbMapping()
            : this("dbo")
        {
        }

        public NblbMapping(string schema)
        {
            ToTable("NBLB", schema);
            HasKey(x => x.Nblb999);

            Property(x => x.Nblb001).HasColumnName(@"NBLB001").HasColumnType("int").IsRequired();
            Property(x => x.Nblb002).HasColumnName(@"NBLB002").HasColumnType("int").IsRequired();
            Property(x => x.Nblb003).HasColumnName(@"NBLB003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb004).HasColumnName(@"NBLB004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb005).HasColumnName(@"NBLB005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Nblb006).HasColumnName(@"NBLB006").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb007).HasColumnName(@"NBLB007").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb008).HasColumnName(@"NBLB008").HasColumnType("int").IsRequired();
            Property(x => x.Nblb009).HasColumnName(@"NBLB009").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nblb010).HasColumnName(@"NBLB010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb011).HasColumnName(@"NBLB011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nblb020).HasColumnName(@"NBLB020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Nblb021).HasColumnName(@"NBLB021").HasColumnType("smallint").IsRequired();
            Property(x => x.Nblb022).HasColumnName(@"NBLB022").HasColumnType("int").IsRequired();
            Property(x => x.Nblb030).HasColumnName(@"NBLB030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nblb040).HasColumnName(@"NBLB040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb041).HasColumnName(@"NBLB041").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb042).HasColumnName(@"NBLB042").HasColumnType("datetime").IsRequired();
            Property(x => x.Nblb050).HasColumnName(@"NBLB050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb051).HasColumnName(@"NBLB051").HasColumnType("datetime").IsRequired();
            Property(x => x.Nblb060).HasColumnName(@"NBLB060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(17);
            Property(x => x.Nblb061).HasColumnName(@"NBLB061").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb062).HasColumnName(@"NBLB062").HasColumnType("datetime").IsRequired();
            Property(x => x.Nblb070).HasColumnName(@"NBLB070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb071).HasColumnName(@"NBLB071").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nblb072).HasColumnName(@"NBLB072").HasColumnType("datetime").IsRequired();
            Property(x => x.Nblb999).HasColumnName(@"NBLB999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
