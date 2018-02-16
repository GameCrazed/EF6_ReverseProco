

namespace Generator
{

    public class CconMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ccon>
    {
        public CconMapping()
            : this("dbo")
        {
        }

        public CconMapping(string schema)
        {
            ToTable("CCON", schema);
            HasKey(x => x.Ccon000);

            Property(x => x.Ccon000).HasColumnName(@"CCON000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ccon001).HasColumnName(@"CCON001").HasColumnType("int").IsRequired();
            Property(x => x.Ccon020).HasColumnName(@"CCON020").HasColumnType("datetime").IsRequired();
            Property(x => x.Ccon030).HasColumnName(@"CCON030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ccon0401).HasColumnName(@"CCON0401").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon0402).HasColumnName(@"CCON0402").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon0403).HasColumnName(@"CCON0403").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon0404).HasColumnName(@"CCON0404").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon0405).HasColumnName(@"CCON0405").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon0406).HasColumnName(@"CCON0406").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon0407).HasColumnName(@"CCON0407").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon0408).HasColumnName(@"CCON0408").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon0409).HasColumnName(@"CCON0409").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon04010).HasColumnName(@"CCON04010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon04011).HasColumnName(@"CCON04011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon04012).HasColumnName(@"CCON04012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ccon090).HasColumnName(@"CCON090").HasColumnType("datetime").IsRequired();
            Property(x => x.Ccon091).HasColumnName(@"CCON091").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
