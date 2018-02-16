

namespace Generator
{

    public class XMsgMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XMsg>
    {
        public XMsgMapping()
            : this("dbo")
        {
        }

        public XMsgMapping(string schema)
        {
            ToTable("X_MSG", schema);
            HasKey(x => x.XMsg001);

            Property(x => x.XMsg001).HasColumnName(@"X_MSG001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XMsg002).HasColumnName(@"X_MSG002").HasColumnType("tinyint").IsRequired();
            Property(x => x.XMsg003).HasColumnName(@"X_MSG003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XMsg004).HasColumnName(@"X_MSG004").HasColumnType("datetime").IsRequired();
            Property(x => x.XMsg005).HasColumnName(@"X_MSG005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.XMsg006).HasColumnName(@"X_MSG006").HasColumnType("datetime").IsRequired();
            Property(x => x.XMsg008).HasColumnName(@"X_MSG008").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.XMsg010).HasColumnName(@"X_MSG010").HasColumnType("int").IsRequired();
            Property(x => x.XMsg020).HasColumnName(@"X_MSG020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
