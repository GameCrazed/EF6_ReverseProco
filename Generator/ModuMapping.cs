

namespace Generator
{

    public class ModuMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Modu>
    {
        public ModuMapping()
            : this("dbo")
        {
        }

        public ModuMapping(string schema)
        {
            ToTable("MODU", schema);
            HasKey(x => new { x.Modu001, x.Modu002 });

            Property(x => x.Modu001).HasColumnName(@"MODU001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Modu002).HasColumnName(@"MODU002").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Modu003).HasColumnName(@"MODU003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Modu004).HasColumnName(@"MODU004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Modu005).HasColumnName(@"MODU005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Modudtm).HasColumnName(@"MODUDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Modu010).HasColumnName(@"MODU010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
