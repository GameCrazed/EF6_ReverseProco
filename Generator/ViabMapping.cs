

namespace Generator
{

    public class ViabMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Viab>
    {
        public ViabMapping()
            : this("dbo")
        {
        }

        public ViabMapping(string schema)
        {
            ToTable("VIAB", schema);
            HasKey(x => x.Viab000);

            Property(x => x.Viab000).HasColumnName(@"VIAB000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Viab001).HasColumnName(@"VIAB001").HasColumnType("int").IsRequired();
            Property(x => x.Viab010).HasColumnName(@"VIAB010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Viab015).HasColumnName(@"VIAB015").HasColumnType("smallint").IsRequired();
            Property(x => x.Viab030).HasColumnName(@"VIAB030").HasColumnType("datetime").IsRequired();
            Property(x => x.Viab035).HasColumnName(@"VIAB035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Viab040).HasColumnName(@"VIAB040").HasColumnType("datetime").IsRequired();
            Property(x => x.Viab050).HasColumnName(@"VIAB050").HasColumnType("smallint").IsRequired();
            Property(x => x.Viab060).HasColumnName(@"VIAB060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab061).HasColumnName(@"VIAB061").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab065).HasColumnName(@"VIAB065").HasColumnType("smallint").IsRequired();
            Property(x => x.Viab0701).HasColumnName(@"VIAB0701").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0702).HasColumnName(@"VIAB0702").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0801).HasColumnName(@"VIAB0801").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0802).HasColumnName(@"VIAB0802").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0803).HasColumnName(@"VIAB0803").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0804).HasColumnName(@"VIAB0804").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0805).HasColumnName(@"VIAB0805").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0806).HasColumnName(@"VIAB0806").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0807).HasColumnName(@"VIAB0807").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0808).HasColumnName(@"VIAB0808").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0809).HasColumnName(@"VIAB0809").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab08010).HasColumnName(@"VIAB08010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab08011).HasColumnName(@"VIAB08011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab08012).HasColumnName(@"VIAB08012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab08013).HasColumnName(@"VIAB08013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab08014).HasColumnName(@"VIAB08014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab08015).HasColumnName(@"VIAB08015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab085).HasColumnName(@"VIAB085").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab087).HasColumnName(@"VIAB087").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab0901).HasColumnName(@"VIAB0901").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab0902).HasColumnName(@"VIAB0902").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab0903).HasColumnName(@"VIAB0903").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab0904).HasColumnName(@"VIAB0904").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab0905).HasColumnName(@"VIAB0905").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab0906).HasColumnName(@"VIAB0906").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab0907).HasColumnName(@"VIAB0907").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab0908).HasColumnName(@"VIAB0908").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab0909).HasColumnName(@"VIAB0909").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab09010).HasColumnName(@"VIAB09010").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab09011).HasColumnName(@"VIAB09011").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab09012).HasColumnName(@"VIAB09012").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab09013).HasColumnName(@"VIAB09013").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab09014).HasColumnName(@"VIAB09014").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab09015).HasColumnName(@"VIAB09015").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab100).HasColumnName(@"VIAB100").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab110).HasColumnName(@"VIAB110").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab115).HasColumnName(@"VIAB115").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Viab125).HasColumnName(@"VIAB125").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Viab127).HasColumnName(@"VIAB127").HasColumnType("smallint").IsRequired();
            Property(x => x.Viab150).HasColumnName(@"VIAB150").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Viab200).HasColumnName(@"VIAB200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab210).HasColumnName(@"VIAB210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab215).HasColumnName(@"VIAB215").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Viab220).HasColumnName(@"VIAB220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab230).HasColumnName(@"VIAB230").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Viab500).HasColumnName(@"VIAB500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Viabdtm).HasColumnName(@"VIABDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
