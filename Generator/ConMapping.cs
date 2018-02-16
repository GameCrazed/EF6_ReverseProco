

namespace Generator
{

    public class ConMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Con>
    {
        public ConMapping()
            : this("dbo")
        {
        }

        public ConMapping(string schema)
        {
            ToTable("CONS", schema);
            HasKey(x => x.Cons030);

            Property(x => x.Cons030).HasColumnName(@"CONS030").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cons040).HasColumnName(@"CONS040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Cons060).HasColumnName(@"CONS060").HasColumnType("smallint").IsRequired();
            Property(x => x.Cons070).HasColumnName(@"CONS070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Cons080).HasColumnName(@"CONS080").HasColumnType("datetime").IsRequired();
            Property(x => x.Cons090).HasColumnName(@"CONS090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Cons100).HasColumnName(@"CONS100").HasColumnType("datetime").IsRequired();
            Property(x => x.Cons050).HasColumnName(@"CONS050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Consdtm).HasColumnName(@"CONSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
