

namespace Generator
{

    public class CdayMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cday>
    {
        public CdayMapping()
            : this("dbo")
        {
        }

        public CdayMapping(string schema)
        {
            ToTable("CDAY", schema);
            HasKey(x => new { x.Cday030, x.Cday010, x.Cday020 });

            Property(x => x.Cday010).HasColumnName(@"CDAY010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cday020).HasColumnName(@"CDAY020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cday030).HasColumnName(@"CDAY030").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cday040).HasColumnName(@"CDAY040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cday050).HasColumnName(@"CDAY050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cdaydtm).HasColumnName(@"CDAYDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
