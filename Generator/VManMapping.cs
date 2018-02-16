

namespace Generator
{

    public class VManMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VMan>
    {
        public VManMapping()
            : this("dbo")
        {
        }

        public VManMapping(string schema)
        {
            ToTable("VMEN", schema);
            HasKey(x => new { x.Vmen001, x.Vmen002 });

            Property(x => x.Vmen001).HasColumnName(@"VMEN001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vmen002).HasColumnName(@"VMEN002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Vmen003).HasColumnName(@"VMEN003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
        }
    }

}
