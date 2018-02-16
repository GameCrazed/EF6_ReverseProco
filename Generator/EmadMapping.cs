

namespace Generator
{

    public class EmadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Emad>
    {
        public EmadMapping()
            : this("dbo")
        {
        }

        public EmadMapping(string schema)
        {
            ToTable("EMAD", schema);
            HasKey(x => x.Emad001);

            Property(x => x.Emad001).HasColumnName(@"EMAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Emad010).HasColumnName(@"EMAD010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Emad020).HasColumnName(@"EMAD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Emad030).HasColumnName(@"EMAD030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
