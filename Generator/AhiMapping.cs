

namespace Generator
{

    public class AhiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ahi>
    {
        public AhiMapping()
            : this("dbo")
        {
        }

        public AhiMapping(string schema)
        {
            ToTable("AHIS", schema);
            HasKey(x => x.Ahis999);

            Property(x => x.Ahis010).HasColumnName(@"AHIS010").HasColumnType("int").IsRequired();
            Property(x => x.Ahis020).HasColumnName(@"AHIS020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ahis040).HasColumnName(@"AHIS040").HasColumnType("datetime").IsRequired();
            Property(x => x.Ahis050).HasColumnName(@"AHIS050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ahis060).HasColumnName(@"AHIS060").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Ahis070).HasColumnName(@"AHIS070").HasColumnType("int").IsRequired();
            Property(x => x.Ahis090).HasColumnName(@"AHIS090").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Ahis100).HasColumnName(@"AHIS100").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Ahis110).HasColumnName(@"AHIS110").HasColumnType("smallint").IsRequired();
            Property(x => x.Ahis120).HasColumnName(@"AHIS120").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Ahis130).HasColumnName(@"AHIS130").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Ahis999).HasColumnName(@"AHIS999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ahisdtm).HasColumnName(@"AHISDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
