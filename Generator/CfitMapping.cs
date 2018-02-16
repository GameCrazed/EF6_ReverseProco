

namespace Generator
{

    public class CfitMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cfit>
    {
        public CfitMapping()
            : this("dbo")
        {
        }

        public CfitMapping(string schema)
        {
            ToTable("CFIT", schema);
            HasKey(x => new { x.Cfit010, x.Cfit030 });

            Property(x => x.Cfit010).HasColumnName(@"CFIT010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cfit020).HasColumnName(@"CFIT020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cfit030).HasColumnName(@"CFIT030").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cfit040).HasColumnName(@"CFIT040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cfit050).HasColumnName(@"CFIT050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Cfit055).HasColumnName(@"CFIT055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Cfit070).HasColumnName(@"CFIT070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cfit080).HasColumnName(@"CFIT080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cfit090).HasColumnName(@"CFIT090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cfit100).HasColumnName(@"CFIT100").HasColumnType("int").IsRequired();
            Property(x => x.Cfit060).HasColumnName(@"CFIT060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cfitdtm).HasColumnName(@"CFITDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Cfit057).HasColumnName(@"CFIT057").HasColumnType("smallint").IsRequired();
        }
    }

}
