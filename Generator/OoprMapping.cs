

namespace Generator
{

    public class OoprMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Oopr>
    {
        public OoprMapping()
            : this("dbo")
        {
        }

        public OoprMapping(string schema)
        {
            ToTable("OOPR", schema);
            HasKey(x => x.Oopr999);

            Property(x => x.Oopr999).HasColumnName(@"OOPR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Oopr010).HasColumnName(@"OOPR010").HasColumnType("int").IsRequired();
            Property(x => x.Oopr020).HasColumnName(@"OOPR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Oopr030).HasColumnName(@"OOPR030").HasColumnType("int").IsRequired();
            Property(x => x.Oopr040).HasColumnName(@"OOPR040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Oopr032).HasColumnName(@"OOPR032").HasColumnType("datetime").IsRequired();
            Property(x => x.Oopr034).HasColumnName(@"OOPR034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Oopr036).HasColumnName(@"OOPR036").HasColumnType("int").IsRequired();
        }
    }

}
