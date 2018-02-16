

namespace Generator
{

    public class CtryMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ctry>
    {
        public CtryMapping()
            : this("dbo")
        {
        }

        public CtryMapping(string schema)
        {
            ToTable("CTRY", schema);
            HasKey(x => x.Ctry030);

            Property(x => x.Ctry030).HasColumnName(@"CTRY030").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ctry040).HasColumnName(@"CTRY040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ctry060).HasColumnName(@"CTRY060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ctry070).HasColumnName(@"CTRY070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Ctry080).HasColumnName(@"CTRY080").HasColumnType("datetime").IsRequired();
            Property(x => x.Ctry090).HasColumnName(@"CTRY090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Ctry100).HasColumnName(@"CTRY100").HasColumnType("datetime").IsRequired();
            Property(x => x.Ctry050).HasColumnName(@"CTRY050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ctry020).HasColumnName(@"ctry020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ctrydtm).HasColumnName(@"CTRYDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Ctry150).HasColumnName(@"CTRY150").HasColumnType("tinyint").IsRequired();
        }
    }

}
