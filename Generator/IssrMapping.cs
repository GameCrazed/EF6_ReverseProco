

namespace Generator
{

    public class IssrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Issr>
    {
        public IssrMapping()
            : this("dbo")
        {
        }

        public IssrMapping(string schema)
        {
            ToTable("ISSR", schema);
            HasKey(x => x.Issr999);

            Property(x => x.Issr010).HasColumnName(@"ISSR010").HasColumnType("int").IsRequired();
            Property(x => x.Issr020).HasColumnName(@"ISSR020").HasColumnType("datetime").IsRequired();
            Property(x => x.Issr030).HasColumnName(@"ISSR030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Issr040).HasColumnName(@"ISSR040").HasColumnType("int").IsRequired();
            Property(x => x.Issr050).HasColumnName(@"ISSR050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Issr060).HasColumnName(@"ISSR060").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Issr070).HasColumnName(@"ISSR070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Issr080).HasColumnName(@"ISSR080").HasColumnType("datetime").IsRequired();
            Property(x => x.Issr090).HasColumnName(@"ISSR090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Issr100).HasColumnName(@"ISSR100").HasColumnType("int").IsRequired();
            Property(x => x.Issr110).HasColumnName(@"ISSR110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Issr130).HasColumnName(@"ISSR130").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Issr999).HasColumnName(@"ISSR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Issr140).HasColumnName(@"ISSR140").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
        }
    }

}
