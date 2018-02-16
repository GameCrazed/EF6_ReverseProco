

namespace Generator
{

    public class FlevMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Flev>
    {
        public FlevMapping()
            : this("dbo")
        {
        }

        public FlevMapping(string schema)
        {
            ToTable("FLEV", schema);
            HasKey(x => x.Flev000);

            Property(x => x.Flev000).HasColumnName(@"FLEV000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Flev005).HasColumnName(@"FLEV005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Flev010).HasColumnName(@"FLEV010").HasColumnType("int").IsRequired();
            Property(x => x.Flev020).HasColumnName(@"FLEV020").HasColumnType("int").IsRequired();
            Property(x => x.Flev030).HasColumnName(@"FLEV030").HasColumnType("int").IsRequired();
            Property(x => x.Flev040).HasColumnName(@"FLEV040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Flev050).HasColumnName(@"FLEV050").HasColumnType("datetime").IsRequired();
            Property(x => x.Flev060).HasColumnName(@"FLEV060").HasColumnType("datetime").IsRequired();
            Property(x => x.Flev070).HasColumnName(@"FLEV070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Flev080).HasColumnName(@"FLEV080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Flev500).HasColumnName(@"FLEV500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
        }
    }

}
