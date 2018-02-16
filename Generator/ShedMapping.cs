

namespace Generator
{

    public class ShedMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Shed>
    {
        public ShedMapping()
            : this("dbo")
        {
        }

        public ShedMapping(string schema)
        {
            ToTable("SHED", schema);
            HasKey(x => x.Shed001);

            Property(x => x.Shed001).HasColumnName(@"SHED001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Shed010).HasColumnName(@"SHED010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed020).HasColumnName(@"SHED020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed030).HasColumnName(@"SHED030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed040).HasColumnName(@"SHED040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed050).HasColumnName(@"SHED050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed060).HasColumnName(@"SHED060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed070).HasColumnName(@"SHED070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed080).HasColumnName(@"SHED080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed090).HasColumnName(@"SHED090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed100).HasColumnName(@"SHED100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed110).HasColumnName(@"SHED110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed120).HasColumnName(@"SHED120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed130).HasColumnName(@"SHED130").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed150).HasColumnName(@"SHED150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed160).HasColumnName(@"SHED160").HasColumnType("datetime").IsRequired();
            Property(x => x.Shed170).HasColumnName(@"SHED170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed180).HasColumnName(@"SHED180").HasColumnType("int").IsRequired();
            Property(x => x.Shed900).HasColumnName(@"SHED900").HasColumnType("int").IsRequired();
            Property(x => x.Shed190).HasColumnName(@"SHED190").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Shed200).HasColumnName(@"SHED200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed350).HasColumnName(@"SHED350").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Shed210).HasColumnName(@"SHED210").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Shed220).HasColumnName(@"SHED220").HasColumnType("datetime").IsRequired();
            Property(x => x.Shed351).HasColumnName(@"SHED351").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Shed352).HasColumnName(@"SHED352").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Shed353).HasColumnName(@"SHED353").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Shed354).HasColumnName(@"SHED354").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Shed355).HasColumnName(@"SHED355").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Shed356).HasColumnName(@"SHED356").HasColumnType("tinyint").IsRequired();
            Property(x => x.Shed357).HasColumnName(@"SHED357").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Shed360).HasColumnName(@"SHED360").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Shed361).HasColumnName(@"SHED361").HasColumnType("tinyint").IsRequired();
            Property(x => x.Shed365).HasColumnName(@"SHED365").HasColumnType("datetime").IsRequired();
            Property(x => x.Shed358).HasColumnName(@"SHED358").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Shed359).HasColumnName(@"SHED359").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Shed400).HasColumnName(@"SHED400").HasColumnType("smallint").IsRequired();
        }
    }

}
