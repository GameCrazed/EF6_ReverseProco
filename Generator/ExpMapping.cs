

namespace Generator
{

    public class ExpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Exp>
    {
        public ExpMapping()
            : this("dbo")
        {
        }

        public ExpMapping(string schema)
        {
            ToTable("EXPS", schema);
            HasKey(x => x.Exps999);

            Property(x => x.Exps005).HasColumnName(@"EXPS005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Exps010).HasColumnName(@"EXPS010").HasColumnType("tinyint").IsRequired();
            Property(x => x.Exps020).HasColumnName(@"EXPS020").HasColumnType("datetime").IsRequired();
            Property(x => x.Exps030).HasColumnName(@"EXPS030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Exps040).HasColumnName(@"EXPS040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Exps050).HasColumnName(@"EXPS050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Exps060).HasColumnName(@"EXPS060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Exps070).HasColumnName(@"EXPS070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Exps999).HasColumnName(@"EXPS999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
