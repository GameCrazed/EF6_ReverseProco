

namespace Generator
{

    public class SealMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Seal>
    {
        public SealMapping()
            : this("dbo")
        {
        }

        public SealMapping(string schema)
        {
            ToTable("SEAL", schema);
            HasKey(x => new { x.Seal010, x.Seal020 });

            Property(x => x.Seal010).HasColumnName(@"SEAL010").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Seal020).HasColumnName(@"SEAL020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Seal030).HasColumnName(@"SEAL030").HasColumnType("datetime").IsRequired();
            Property(x => x.Seal050).HasColumnName(@"SEAL050").HasColumnType("int").IsRequired();
            Property(x => x.Seal060).HasColumnName(@"SEAL060").HasColumnType("int").IsRequired();
            Property(x => x.Seal070).HasColumnName(@"SEAL070").HasColumnType("int").IsRequired();
            Property(x => x.Seal080).HasColumnName(@"SEAL080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Seal090).HasColumnName(@"SEAL090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Seal110).HasColumnName(@"SEAL110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Seal040).HasColumnName(@"SEAL040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Seal100).HasColumnName(@"SEAL100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Sealdtm).HasColumnName(@"SEALDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
