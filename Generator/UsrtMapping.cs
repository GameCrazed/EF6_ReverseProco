

namespace Generator
{

    public class UsrtMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Usrt>
    {
        public UsrtMapping()
            : this("dbo")
        {
        }

        public UsrtMapping(string schema)
        {
            ToTable("USRT", schema);
            HasKey(x => x.Usrt999);

            Property(x => x.Usrt001).HasColumnName(@"USRT001").HasColumnType("int").IsRequired();
            Property(x => x.Usrt002).HasColumnName(@"USRT002").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Usrt010).HasColumnName(@"USRT010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Usrt011).HasColumnName(@"USRT011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Usrt012).HasColumnName(@"USRT012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Usrt013).HasColumnName(@"USRT013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Usrt020).HasColumnName(@"USRT020").HasColumnType("datetime").IsRequired();
            Property(x => x.Usrt021).HasColumnName(@"USRT021").HasColumnType("int").IsRequired();
            Property(x => x.Usrt030).HasColumnName(@"USRT030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Usrt031).HasColumnName(@"USRT031").HasColumnType("datetime").IsRequired();
            Property(x => x.Usrt032).HasColumnName(@"USRT032").HasColumnType("int").IsRequired();
            Property(x => x.Usrt050).HasColumnName(@"USRT050").HasColumnType("int").IsRequired();
            Property(x => x.Usrt999).HasColumnName(@"USRT999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Usrt040).HasColumnName(@"USRT040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Usrt060).HasColumnName(@"USRT060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Usrt061).HasColumnName(@"USRT061").HasColumnType("datetime").IsRequired();
            Property(x => x.Usrt070).HasColumnName(@"USRT070").HasColumnType("tinyint").IsRequired();
        }
    }

}
