

namespace Generator
{

    public class DdocMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ddoc>
    {
        public DdocMapping()
            : this("dbo")
        {
        }

        public DdocMapping(string schema)
        {
            ToTable("DDOC", schema);
            HasKey(x => x.Ddoc001);

            Property(x => x.Ddoc001).HasColumnName(@"DDOC001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ddoc003).HasColumnName(@"DDOC003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ddoc010).HasColumnName(@"DDOC010").HasColumnType("int").IsRequired();
            Property(x => x.Ddoc015).HasColumnName(@"DDOC015").HasColumnType("int").IsRequired();
            Property(x => x.Ddoc020).HasColumnName(@"DDOC020").HasColumnType("int").IsRequired();
            Property(x => x.Ddoc030).HasColumnName(@"DDOC030").HasColumnType("int").IsRequired();
            Property(x => x.Ddoc035).HasColumnName(@"DDOC035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ddoc040).HasColumnName(@"DDOC040").HasColumnType("datetime").IsRequired();
            Property(x => x.Ddoc045).HasColumnName(@"DDOC045").HasColumnType("datetime").IsRequired();
            Property(x => x.Ddoc050).HasColumnName(@"DDOC050").HasColumnType("int").IsRequired();
            Property(x => x.Ddoc055).HasColumnName(@"DDOC055").HasColumnType("datetime").IsRequired();
        }
    }

}
