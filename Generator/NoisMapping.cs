

namespace Generator
{

    public class NoisMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nois>
    {
        public NoisMapping()
            : this("dbo")
        {
        }

        public NoisMapping(string schema)
        {
            ToTable("NOIS", schema);
            HasKey(x => x.Nois000);

            Property(x => x.Nois000).HasColumnName(@"NOIS000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nois003).HasColumnName(@"NOIS003").HasColumnType("int").IsRequired();
            Property(x => x.Nois004).HasColumnName(@"NOIS004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nois005).HasColumnName(@"NOIS005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nois010).HasColumnName(@"NOIS010").HasColumnType("int").IsRequired();
            Property(x => x.Nois015).HasColumnName(@"NOIS015").HasColumnType("int").IsRequired();
            Property(x => x.Nois016).HasColumnName(@"NOIS016").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nois025).HasColumnName(@"NOIS025").HasColumnType("datetime").IsRequired();
            Property(x => x.Nois030).HasColumnName(@"NOIS030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nois080).HasColumnName(@"NOIS080").HasColumnType("datetime").IsRequired();
            Property(x => x.Nois085).HasColumnName(@"NOIS085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nois100).HasColumnName(@"NOIS100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nois110).HasColumnName(@"NOIS110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nois120).HasColumnName(@"NOIS120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nois130).HasColumnName(@"NOIS130").HasColumnType("datetime").IsRequired();
            Property(x => x.Nois140).HasColumnName(@"NOIS140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nois150).HasColumnName(@"NOIS150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Nois160).HasColumnName(@"NOIS160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nois170).HasColumnName(@"NOIS170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nois180).HasColumnName(@"NOIS180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nois190).HasColumnName(@"NOIS190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Nois200).HasColumnName(@"NOIS200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nois210).HasColumnName(@"NOIS210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nois220).HasColumnName(@"NOIS220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nois300).HasColumnName(@"NOIS300").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Nois310).HasColumnName(@"NOIS310").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Nois320).HasColumnName(@"NOIS320").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Nois330).HasColumnName(@"NOIS330").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nois340).HasColumnName(@"NOIS340").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nois350).HasColumnName(@"NOIS350").HasColumnType("int").IsRequired();
            Property(x => x.Nois360).HasColumnName(@"NOIS360").HasColumnType("int").IsRequired();
            Property(x => x.Nois002).HasColumnName(@"NOIS002").HasColumnType("int").IsRequired();
        }
    }

}
