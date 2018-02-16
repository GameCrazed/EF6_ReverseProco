

namespace Generator
{

    public class OradMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Orad>
    {
        public OradMapping()
            : this("dbo")
        {
        }

        public OradMapping(string schema)
        {
            ToTable("ORAD", schema);
            HasKey(x => x.Orad001);

            Property(x => x.Orad001).HasColumnName(@"ORAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Orad055).HasColumnName(@"ORAD055").HasColumnType("int").IsRequired();
            Property(x => x.Orad056).HasColumnName(@"ORAD056").HasColumnType("datetime").IsRequired();
            Property(x => x.Orad100).HasColumnName(@"ORAD100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad110).HasColumnName(@"ORAD110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad120).HasColumnName(@"ORAD120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Orad190).HasColumnName(@"ORAD190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad200).HasColumnName(@"ORAD200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad210).HasColumnName(@"ORAD210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad220).HasColumnName(@"ORAD220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad230).HasColumnName(@"ORAD230").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad300).HasColumnName(@"ORAD300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Orad310).HasColumnName(@"ORAD310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Orad320).HasColumnName(@"ORAD320").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad400).HasColumnName(@"ORAD400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Orad420).HasColumnName(@"ORAD420").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Orad900).HasColumnName(@"ORAD900").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad060).HasColumnName(@"ORAD060").HasColumnType("int").IsRequired();
            Property(x => x.Orad061).HasColumnName(@"ORAD061").HasColumnType("datetime").IsRequired();
            Property(x => x.Orad500).HasColumnName(@"ORAD500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad510).HasColumnName(@"ORAD510").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Orad062).HasColumnName(@"ORAD062").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Orad550).HasColumnName(@"ORAD550").HasColumnType("datetime").IsRequired();
        }
    }

}
