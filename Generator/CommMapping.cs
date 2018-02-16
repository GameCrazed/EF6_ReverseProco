

namespace Generator
{

    public class CommMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Comm>
    {
        public CommMapping()
            : this("dbo")
        {
        }

        public CommMapping(string schema)
        {
            ToTable("COMM", schema);
            HasKey(x => x.Comm000);

            Property(x => x.Comm000).HasColumnName(@"COMM000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Comm010).HasColumnName(@"COMM010").HasColumnType("int").IsRequired();
            Property(x => x.Comm015).HasColumnName(@"COMM015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comm020).HasColumnName(@"COMM020").HasColumnType("int").IsRequired();
            Property(x => x.Comm025).HasColumnName(@"COMM025").HasColumnType("datetime").IsRequired();
            Property(x => x.Comm030).HasColumnName(@"COMM030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Comm035).HasColumnName(@"COMM035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comm040).HasColumnName(@"COMM040").HasColumnType("int").IsRequired();
            Property(x => x.Comm045).HasColumnName(@"COMM045").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Comm050).HasColumnName(@"COMM050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Comm055).HasColumnName(@"COMM055").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Comm060).HasColumnName(@"COMM060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comm065).HasColumnName(@"COMM065").HasColumnType("datetime").IsRequired();
            Property(x => x.Comm070).HasColumnName(@"COMM070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Comm080).HasColumnName(@"COMM080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
        }
    }

}
