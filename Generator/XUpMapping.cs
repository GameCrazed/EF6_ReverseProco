

namespace Generator
{

    public class XUpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XUp>
    {
        public XUpMapping()
            : this("dbo")
        {
        }

        public XUpMapping(string schema)
        {
            ToTable("X__UP", schema);
            HasKey(x => x.XUp999);

            Property(x => x.XUp010).HasColumnName(@"X__UP010").HasColumnType("datetime").IsRequired();
            Property(x => x.XUp020).HasColumnName(@"X__UP020").HasColumnType("int").IsRequired();
            Property(x => x.XUp030).HasColumnName(@"X__UP030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XUp999).HasColumnName(@"X__UP999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XUp0401).HasColumnName(@"X__UP0401").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp0402).HasColumnName(@"X__UP0402").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp0403).HasColumnName(@"X__UP0403").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp0404).HasColumnName(@"X__UP0404").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp0405).HasColumnName(@"X__UP0405").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp0406).HasColumnName(@"X__UP0406").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp0407).HasColumnName(@"X__UP0407").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp0408).HasColumnName(@"X__UP0408").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp0409).HasColumnName(@"X__UP0409").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp04010).HasColumnName(@"X__UP04010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp04011).HasColumnName(@"X__UP04011").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp04012).HasColumnName(@"X__UP04012").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp04013).HasColumnName(@"X__UP04013").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp04014).HasColumnName(@"X__UP04014").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUp04015).HasColumnName(@"X__UP04015").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.XUpdtm).HasColumnName(@"X__UPDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.XUp015).HasColumnName(@"X__UP015").HasColumnType("tinyint").IsRequired();
        }
    }

}
