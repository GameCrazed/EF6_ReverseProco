

namespace Generator
{

    public class NbxrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbxr>
    {
        public NbxrMapping()
            : this("dbo")
        {
        }

        public NbxrMapping(string schema)
        {
            ToTable("NBXR", schema);
            HasKey(x => new { x.Nbxr015, x.Nbxr001 });

            Property(x => x.Nbxr001).HasColumnName(@"NBXR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbxr010).HasColumnName(@"NBXR010").HasColumnType("int").IsRequired();
            Property(x => x.Nbxr015).HasColumnName(@"NBXR015").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbxr021).HasColumnName(@"NBXR021").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Nbxr230).HasColumnName(@"NBXR230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbxr270).HasColumnName(@"NBXR270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbxr900).HasColumnName(@"NBXR900").HasColumnType("tinyint").IsRequired();
        }
    }

}
