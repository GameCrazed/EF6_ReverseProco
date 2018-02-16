

namespace Generator
{

    public class PreMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pre>
    {
        public PreMapping()
            : this("dbo")
        {
        }

        public PreMapping(string schema)
        {
            ToTable("PRES", schema);
            HasKey(x => x.Pres001);

            Property(x => x.Pres001).HasColumnName(@"PRES001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pres010).HasColumnName(@"PRES010").HasColumnType("int").IsRequired();
            Property(x => x.Pres020).HasColumnName(@"PRES020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Pres053).HasColumnName(@"PRES053").HasColumnType("smallint").IsRequired();
            Property(x => x.Pres055).HasColumnName(@"PRES055").HasColumnType("int").IsRequired();
            Property(x => x.Pres064).HasColumnName(@"PRES064").HasColumnType("int").IsRequired();
            Property(x => x.Pres200).HasColumnName(@"PRES200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pres210).HasColumnName(@"PRES210").HasColumnType("int").IsRequired();
            Property(x => x.Pres220).HasColumnName(@"PRES220").HasColumnType("datetime").IsRequired();
            Property(x => x.Pres230).HasColumnName(@"PRES230").HasColumnType("datetime").IsRequired();
            Property(x => x.Pres290).HasColumnName(@"PRES290").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pres300).HasColumnName(@"PRES300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pres305).HasColumnName(@"PRES305").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pres310).HasColumnName(@"PRES310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pres315).HasColumnName(@"PRES315").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pres320).HasColumnName(@"PRES320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pres325).HasColumnName(@"PRES325").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pres390).HasColumnName(@"PRES390").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
        }
    }

}
