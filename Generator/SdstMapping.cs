

namespace Generator
{

    public class SdstMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sdst>
    {
        public SdstMapping()
            : this("dbo")
        {
        }

        public SdstMapping(string schema)
        {
            ToTable("SDST", schema);
            HasKey(x => x.Sdst000);

            Property(x => x.Sdst000).HasColumnName(@"SDST000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Sdst010).HasColumnName(@"SDST010").HasColumnType("int").IsRequired();
            Property(x => x.Sdst020).HasColumnName(@"SDST020").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Sdst030).HasColumnName(@"SDST030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Sdst040).HasColumnName(@"SDST040").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Sdst050).HasColumnName(@"SDST050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Sdst060).HasColumnName(@"SDST060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Sdst140).HasColumnName(@"SDST140").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Sdst150).HasColumnName(@"SDST150").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Sdst160).HasColumnName(@"SDST160").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Sdst015).HasColumnName(@"SDST015").HasColumnType("tinyint").IsRequired();
            Property(x => x.Sdst025).HasColumnName(@"SDST025").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Sdst026).HasColumnName(@"SDST026").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Sdst170).HasColumnName(@"SDST170").HasColumnType("tinyint").IsRequired();
            Property(x => x.Sdst300).HasColumnName(@"SDST300").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Sdst320).HasColumnName(@"SDST320").HasColumnType("datetime").IsRequired();
            Property(x => x.Sdst180).HasColumnName(@"SDST180").HasColumnType("tinyint").IsRequired();
            Property(x => x.Sdst005).HasColumnName(@"SDST005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Sdst007).HasColumnName(@"SDST007").HasColumnType("datetime").IsRequired();
            Property(x => x.Sdst065).HasColumnName(@"SDST065").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Sdst165).HasColumnName(@"SDST165").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
