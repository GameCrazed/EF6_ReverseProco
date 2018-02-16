

namespace Generator
{

    public class DmovMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Dmov>
    {
        public DmovMapping()
            : this("dbo")
        {
        }

        public DmovMapping(string schema)
        {
            ToTable("DMOV", schema);
            HasKey(x => x.Dmov001);

            Property(x => x.Dmov001).HasColumnName(@"DMOV001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Dmov010).HasColumnName(@"DMOV010").HasColumnType("int").IsRequired();
            Property(x => x.Dmov015).HasColumnName(@"DMOV015").HasColumnType("int").IsRequired();
            Property(x => x.Dmov030).HasColumnName(@"DMOV030").HasColumnType("int").IsRequired();
            Property(x => x.Dmov040).HasColumnName(@"DMOV040").HasColumnType("datetime").IsRequired();
            Property(x => x.Dmov999).HasColumnName(@"DMOV999").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Dmov500).HasColumnName(@"DMOV500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
        }
    }

}
