

namespace Generator
{

    public class FaveMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fave>
    {
        public FaveMapping()
            : this("dbo")
        {
        }

        public FaveMapping(string schema)
        {
            ToTable("FAVE", schema);
            HasKey(x => x.Fave015);

            Property(x => x.Fave010).HasColumnName(@"FAVE010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fave015).HasColumnName(@"FAVE015").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fave020).HasColumnName(@"FAVE020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Fave030).HasColumnName(@"FAVE030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fave040).HasColumnName(@"FAVE040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Fave050).HasColumnName(@"FAVE050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Fave060).HasColumnName(@"FAVE060").HasColumnType("int").IsRequired();
            Property(x => x.Fave070).HasColumnName(@"FAVE070").HasColumnType("datetime").IsRequired();
            Property(x => x.Fave080).HasColumnName(@"FAVE080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fave090).HasColumnName(@"FAVE090").HasColumnType("tinyint").IsRequired();
        }
    }

}
