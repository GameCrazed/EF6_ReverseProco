

namespace Generator
{

    public class ItvrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Itvr>
    {
        public ItvrMapping()
            : this("dbo")
        {
        }

        public ItvrMapping(string schema)
        {
            ToTable("ITVR", schema);
            HasKey(x => new { x.Itvr010, x.Itvr020 });

            Property(x => x.Itvr010).HasColumnName(@"ITVR010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Itvr020).HasColumnName(@"ITVR020").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Itvr0401).HasColumnName(@"ITVR0401").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0402).HasColumnName(@"ITVR0402").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0403).HasColumnName(@"ITVR0403").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0404).HasColumnName(@"ITVR0404").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0405).HasColumnName(@"ITVR0405").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0406).HasColumnName(@"ITVR0406").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0407).HasColumnName(@"ITVR0407").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0408).HasColumnName(@"ITVR0408").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0409).HasColumnName(@"ITVR0409").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr04010).HasColumnName(@"ITVR04010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Itvr0501).HasColumnName(@"ITVR0501").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0502).HasColumnName(@"ITVR0502").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0503).HasColumnName(@"ITVR0503").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0504).HasColumnName(@"ITVR0504").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0505).HasColumnName(@"ITVR0505").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0506).HasColumnName(@"ITVR0506").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0507).HasColumnName(@"ITVR0507").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0508).HasColumnName(@"ITVR0508").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0509).HasColumnName(@"ITVR0509").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr05010).HasColumnName(@"ITVR05010").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Itvr0601).HasColumnName(@"ITVR0601").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr0602).HasColumnName(@"ITVR0602").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr0603).HasColumnName(@"ITVR0603").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr0604).HasColumnName(@"ITVR0604").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr0605).HasColumnName(@"ITVR0605").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr0606).HasColumnName(@"ITVR0606").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr0607).HasColumnName(@"ITVR0607").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr0608).HasColumnName(@"ITVR0608").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr0609).HasColumnName(@"ITVR0609").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr06010).HasColumnName(@"ITVR06010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Itvr070).HasColumnName(@"ITVR070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Itvrdtm).HasColumnName(@"ITVRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
