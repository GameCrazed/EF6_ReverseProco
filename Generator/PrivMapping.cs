

namespace Generator
{

    public class PrivMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Priv>
    {
        public PrivMapping()
            : this("dbo")
        {
        }

        public PrivMapping(string schema)
        {
            ToTable("PRIV", schema);
            HasKey(x => new { x.Priv020, x.Priv010, x.Priv030, x.Priv050 });

            Property(x => x.Priv010).HasColumnName(@"PRIV010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Priv020).HasColumnName(@"PRIV020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Priv030).HasColumnName(@"PRIV030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Priv040).HasColumnName(@"PRIV040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Privdtm).HasColumnName(@"PRIVDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Priv999).HasColumnName(@"PRIV999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Priv050).HasColumnName(@"PRIV050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Priv060).HasColumnName(@"PRIV060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
        }
    }

}
