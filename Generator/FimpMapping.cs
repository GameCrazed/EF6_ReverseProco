

namespace Generator
{

    public class FimpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fimp>
    {
        public FimpMapping()
            : this("dbo")
        {
        }

        public FimpMapping(string schema)
        {
            ToTable("FIMP", schema);
            HasKey(x => x.Fimp999);

            Property(x => x.Fimp010).HasColumnName(@"FIMP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Fimp020).HasColumnName(@"FIMP020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fimp030).HasColumnName(@"FIMP030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fimp040).HasColumnName(@"FIMP040").HasColumnType("datetime").IsRequired();
            Property(x => x.Fimp050).HasColumnName(@"FIMP050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fimp999).HasColumnName(@"FIMP999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
