

namespace Generator
{

    public class VhiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vhi>
    {
        public VhiMapping()
            : this("dbo")
        {
        }

        public VhiMapping(string schema)
        {
            ToTable("VHIS", schema);
            HasKey(x => x.Vhis000);

            Property(x => x.Vhis000).HasColumnName(@"VHIS000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Vhis005).HasColumnName(@"VHIS005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Vhis015).HasColumnName(@"VHIS015").HasColumnType("int").IsRequired();
            Property(x => x.Vhis020).HasColumnName(@"VHIS020").HasColumnType("datetime").IsRequired();
            Property(x => x.Vhis025).HasColumnName(@"VHIS025").HasColumnType("int").IsRequired();
            Property(x => x.Vhis030).HasColumnName(@"VHIS030").HasColumnType("datetime").IsRequired();
            Property(x => x.Vhis035).HasColumnName(@"VHIS035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Vhis040).HasColumnName(@"VHIS040").HasColumnType("int").IsRequired();
            Property(x => x.Vhis045).HasColumnName(@"VHIS045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
        }
    }

}
