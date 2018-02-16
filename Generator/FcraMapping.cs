

namespace Generator
{

    public class FcraMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Fcra>
    {
        public FcraMapping()
            : this("dbo")
        {
        }

        public FcraMapping(string schema)
        {
            ToTable("FCRA", schema);
            HasKey(x => x.Fcra999);

            Property(x => x.Fcra010).HasColumnName(@"FCRA010").HasColumnType("int").IsRequired();
            Property(x => x.Fcra020).HasColumnName(@"FCRA020").HasColumnType("int").IsRequired();
            Property(x => x.Fcra030).HasColumnName(@"FCRA030").HasColumnType("int").IsRequired();
            Property(x => x.Fcra040).HasColumnName(@"FCRA040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Fcra050).HasColumnName(@"FCRA050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Fcra060).HasColumnName(@"FCRA060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fcra070).HasColumnName(@"FCRA070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Fcra080).HasColumnName(@"FCRA080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Fcra090).HasColumnName(@"FCRA090").HasColumnType("datetime").IsRequired();
            Property(x => x.Fcra100).HasColumnName(@"FCRA100").HasColumnType("int").IsRequired();
            Property(x => x.Fcra999).HasColumnName(@"FCRA999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fcra032).HasColumnName(@"FCRA032").HasColumnType("datetime").IsRequired();
            Property(x => x.Fcra034).HasColumnName(@"FCRA034").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Fcra036).HasColumnName(@"FCRA036").HasColumnType("int").IsRequired();
        }
    }

}
