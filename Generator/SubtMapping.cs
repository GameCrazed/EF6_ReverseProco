

namespace Generator
{

    public class SubtMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Subt>
    {
        public SubtMapping()
            : this("dbo")
        {
        }

        public SubtMapping(string schema)
        {
            ToTable("SUBT", schema);
            HasKey(x => new { x.Subt080, x.Subt090 });

            Property(x => x.Subt010).HasColumnName(@"SUBT010").HasColumnType("int").IsRequired();
            Property(x => x.Subt020).HasColumnName(@"SUBT020").HasColumnType("int").IsRequired();
            Property(x => x.Subt030).HasColumnName(@"SUBT030").HasColumnType("datetime").IsRequired();
            Property(x => x.Subt040).HasColumnName(@"SUBT040").HasColumnType("smallint").IsRequired();
            Property(x => x.Subt050).HasColumnName(@"SUBT050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Subt060).HasColumnName(@"SUBT060").HasColumnType("datetime").IsRequired();
            Property(x => x.Subt070).HasColumnName(@"SUBT070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Subt080).HasColumnName(@"SUBT080").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Subt090).HasColumnName(@"SUBT090").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Subt110).HasColumnName(@"SUBT110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Subt120).HasColumnName(@"SUBT120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Subt130).HasColumnName(@"SUBT130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Subt140).HasColumnName(@"SUBT140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Subt150).HasColumnName(@"SUBT150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Subt160).HasColumnName(@"SUBT160").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(11);
            Property(x => x.Subt180).HasColumnName(@"SUBT180").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Subt190).HasColumnName(@"SUBT190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Subtdtm).HasColumnName(@"SUBTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
