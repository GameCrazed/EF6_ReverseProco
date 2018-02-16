

namespace Generator
{

    public class EndrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Endr>
    {
        public EndrMapping()
            : this("dbo")
        {
        }

        public EndrMapping(string schema)
        {
            ToTable("ENDR", schema);
            HasKey(x => new { x.Endr000, x.Endr001 });

            Property(x => x.Endr000).HasColumnName(@"ENDR000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Endr001).HasColumnName(@"ENDR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Endr003).HasColumnName(@"ENDR003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Endr005).HasColumnName(@"ENDR005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr011).HasColumnName(@"ENDR011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr012).HasColumnName(@"ENDR012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr013).HasColumnName(@"ENDR013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr014).HasColumnName(@"ENDR014").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr015).HasColumnName(@"ENDR015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr016).HasColumnName(@"ENDR016").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr017).HasColumnName(@"ENDR017").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr018).HasColumnName(@"ENDR018").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr019).HasColumnName(@"ENDR019").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr020).HasColumnName(@"ENDR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr021).HasColumnName(@"ENDR021").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr022).HasColumnName(@"ENDR022").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr023).HasColumnName(@"ENDR023").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr024).HasColumnName(@"ENDR024").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr025).HasColumnName(@"ENDR025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr026).HasColumnName(@"ENDR026").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr027).HasColumnName(@"ENDR027").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr028).HasColumnName(@"ENDR028").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr029).HasColumnName(@"ENDR029").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr030).HasColumnName(@"ENDR030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Endr100).HasColumnName(@"ENDR100").HasColumnType("datetime").IsRequired();
            Property(x => x.Endr500).HasColumnName(@"ENDR500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
        }
    }

}
