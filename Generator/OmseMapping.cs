

namespace Generator
{

    public class OmseMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Omse>
    {
        public OmseMapping()
            : this("dbo")
        {
        }

        public OmseMapping(string schema)
        {
            ToTable("OMSE", schema);
            HasKey(x => new { x.Omse010, x.Omse020, x.Omse030, x.Omse040 });

            Property(x => x.Omse010).HasColumnName(@"OMSE010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Omse020).HasColumnName(@"OMSE020").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Omse030).HasColumnName(@"OMSE030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Omse040).HasColumnName(@"OMSE040").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Omse050).HasColumnName(@"OMSE050").HasColumnType("int").IsRequired();
            Property(x => x.Omse060).HasColumnName(@"OMSE060").HasColumnType("int").IsRequired();
            Property(x => x.Omse070).HasColumnName(@"OMSE070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
