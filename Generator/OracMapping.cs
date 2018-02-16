

namespace Generator
{

    public class OracMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Orac>
    {
        public OracMapping()
            : this("dbo")
        {
        }

        public OracMapping(string schema)
        {
            ToTable("ORAC", schema);
            HasKey(x => new { x.Orac010, x.Orac035, x.Orac080 });

            Property(x => x.Orac010).HasColumnName(@"ORAC010").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orac020).HasColumnName(@"ORAC020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Orac030).HasColumnName(@"ORAC030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Orac035).HasColumnName(@"ORAC035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orac040).HasColumnName(@"ORAC040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Orac050).HasColumnName(@"ORAC050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Orac060).HasColumnName(@"ORAC060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Orac070).HasColumnName(@"ORAC070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Orac080).HasColumnName(@"ORAC080").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
