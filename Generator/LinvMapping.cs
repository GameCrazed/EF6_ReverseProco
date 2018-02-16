

namespace Generator
{

    public class LinvMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Linv>
    {
        public LinvMapping()
            : this("dbo")
        {
        }

        public LinvMapping(string schema)
        {
            ToTable("LINV", schema);
            HasKey(x => x.Linv060);

            Property(x => x.Linv010).HasColumnName(@"LINV010").HasColumnType("int").IsRequired();
            Property(x => x.Linv020).HasColumnName(@"LINV020").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv030).HasColumnName(@"LINV030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Linv050).HasColumnName(@"LINV050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Linv060).HasColumnName(@"LINV060").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Linv070).HasColumnName(@"LINV070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Linv080).HasColumnName(@"LINV080").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv090).HasColumnName(@"LINV090").HasColumnType("smallint").IsRequired();
            Property(x => x.Linvdtm).HasColumnName(@"LINVDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Linv0451).HasColumnName(@"LINV0451").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0452).HasColumnName(@"LINV0452").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0453).HasColumnName(@"LINV0453").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0454).HasColumnName(@"LINV0454").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0455).HasColumnName(@"LINV0455").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0456).HasColumnName(@"LINV0456").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0457).HasColumnName(@"LINV0457").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0458).HasColumnName(@"LINV0458").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0459).HasColumnName(@"LINV0459").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv04510).HasColumnName(@"LINV04510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv04511).HasColumnName(@"LINV04511").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv04512).HasColumnName(@"LINV04512").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0471).HasColumnName(@"LINV0471").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0472).HasColumnName(@"LINV0472").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0473).HasColumnName(@"LINV0473").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0474).HasColumnName(@"LINV0474").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0475).HasColumnName(@"LINV0475").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0476).HasColumnName(@"LINV0476").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0477).HasColumnName(@"LINV0477").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0478).HasColumnName(@"LINV0478").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv0479).HasColumnName(@"LINV0479").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv04710).HasColumnName(@"LINV04710").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv04711).HasColumnName(@"LINV04711").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv04712).HasColumnName(@"LINV04712").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Linv100).HasColumnName(@"LINV100").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Linv095).HasColumnName(@"LINV095").HasColumnType("int").IsRequired();
            Property(x => x.Linv0401).HasColumnName(@"LINV0401").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv0402).HasColumnName(@"LINV0402").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv0403).HasColumnName(@"LINV0403").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv0404).HasColumnName(@"LINV0404").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv0405).HasColumnName(@"LINV0405").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv0406).HasColumnName(@"LINV0406").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv0407).HasColumnName(@"LINV0407").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv0408).HasColumnName(@"LINV0408").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv0409).HasColumnName(@"LINV0409").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv04010).HasColumnName(@"LINV04010").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv04011).HasColumnName(@"LINV04011").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv04012).HasColumnName(@"LINV04012").HasColumnType("datetime").IsRequired();
            Property(x => x.Linv011).HasColumnName(@"LINV011").HasColumnType("int").IsRequired();
            Property(x => x.Linv035).HasColumnName(@"LINV035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Linv130).HasColumnName(@"LINV130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Linv140).HasColumnName(@"LINV140").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Linv200).HasColumnName(@"LINV200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
