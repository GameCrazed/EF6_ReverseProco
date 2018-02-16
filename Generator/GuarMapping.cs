

namespace Generator
{

    public class GuarMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Guar>
    {
        public GuarMapping()
            : this("dbo")
        {
        }

        public GuarMapping(string schema)
        {
            ToTable("GUAR", schema);
            HasKey(x => x.Guar000);

            Property(x => x.Guar000).HasColumnName(@"GUAR000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Guar001).HasColumnName(@"GUAR001").HasColumnType("int").IsRequired();
            Property(x => x.Guar002).HasColumnName(@"GUAR002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Guar004).HasColumnName(@"GUAR004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Guar005).HasColumnName(@"GUAR005").HasColumnType("int").IsRequired();
            Property(x => x.Guar010).HasColumnName(@"GUAR010").HasColumnType("int").IsRequired();
            Property(x => x.Guar015).HasColumnName(@"GUAR015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Guar020).HasColumnName(@"GUAR020").HasColumnType("int").IsRequired();
            Property(x => x.Guar030).HasColumnName(@"GUAR030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Guar040).HasColumnName(@"GUAR040").HasColumnType("datetime").IsRequired();
            Property(x => x.Guar090).HasColumnName(@"GUAR090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Guar100).HasColumnName(@"GUAR100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Guar110).HasColumnName(@"GUAR110").HasColumnType("int").IsRequired();
            Property(x => x.Guar120).HasColumnName(@"GUAR120").HasColumnType("datetime").IsRequired();
        }
    }

}
