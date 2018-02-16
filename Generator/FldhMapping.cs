

namespace Generator
{

    public class FldhMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fldh>
    {
        public FldhMapping()
            : this("dbo")
        {
        }

        public FldhMapping(string schema)
        {
            ToTable("FLDH", schema);
            HasKey(x => new { x.Fldh001, x.Fldh005 });

            Property(x => x.Fldh001).HasColumnName(@"FLDH001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(11).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fldh005).HasColumnName(@"FLDH005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Fldh500).HasColumnName(@"FLDH500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(750);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fldhdtm).HasColumnName(@"FLDHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Fldh010).HasColumnName(@"FLDH010").HasColumnType("datetime").IsRequired();
            Property(x => x.Fldh020).HasColumnName(@"FLDH020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
