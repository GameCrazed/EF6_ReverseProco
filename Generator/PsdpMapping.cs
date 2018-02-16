

namespace Generator
{

    public class PsdpMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Psdp>
    {
        public PsdpMapping()
            : this("dbo")
        {
        }

        public PsdpMapping(string schema)
        {
            ToTable("PSDP", schema);
            HasKey(x => x.Psdp000);

            Property(x => x.Psdp000).HasColumnName(@"PSDP000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Psdp001).HasColumnName(@"PSDP001").HasColumnType("int").IsRequired();
            Property(x => x.Psdp010).HasColumnName(@"PSDP010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Psdp020).HasColumnName(@"PSDP020").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp030).HasColumnName(@"PSDP030").HasColumnType("int").IsRequired();
            Property(x => x.Psdp100).HasColumnName(@"PSDP100").HasColumnType("int").IsRequired();
            Property(x => x.Psdp110).HasColumnName(@"PSDP110").HasColumnType("int").IsRequired();
            Property(x => x.Psdp115).HasColumnName(@"PSDP115").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Psdp120).HasColumnName(@"PSDP120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Psdp130).HasColumnName(@"PSDP130").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp140).HasColumnName(@"PSDP140").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp150).HasColumnName(@"PSDP150").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp160).HasColumnName(@"PSDP160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp170).HasColumnName(@"PSDP170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdp180).HasColumnName(@"PSDP180").HasColumnType("int").IsRequired();
            Property(x => x.Psdp190).HasColumnName(@"PSDP190").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdp200).HasColumnName(@"PSDP200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdp210).HasColumnName(@"PSDP210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdp220).HasColumnName(@"PSDP220").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Psdp230).HasColumnName(@"PSDP230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Psdp240).HasColumnName(@"PSDP240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp250).HasColumnName(@"PSDP250").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp260).HasColumnName(@"PSDP260").HasColumnType("int").IsRequired();
            Property(x => x.Psdp270).HasColumnName(@"PSDP270").HasColumnType("int").IsRequired();
            Property(x => x.Psdp280).HasColumnName(@"PSDP280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp290).HasColumnName(@"PSDP290").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp300).HasColumnName(@"PSDP300").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdp305).HasColumnName(@"PSDP305").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp310).HasColumnName(@"PSDP310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp311).HasColumnName(@"PSDP311").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp315).HasColumnName(@"PSDP315").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp316).HasColumnName(@"PSDP316").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp320).HasColumnName(@"PSDP320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp321).HasColumnName(@"PSDP321").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp330).HasColumnName(@"PSDP330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp331).HasColumnName(@"PSDP331").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp340).HasColumnName(@"PSDP340").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp341).HasColumnName(@"PSDP341").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp350).HasColumnName(@"PSDP350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp351).HasColumnName(@"PSDP351").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp360).HasColumnName(@"PSDP360").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp361).HasColumnName(@"PSDP361").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp370).HasColumnName(@"PSDP370").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp380).HasColumnName(@"PSDP380").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdp381).HasColumnName(@"PSDP381").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdp390).HasColumnName(@"PSDP390").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdp391).HasColumnName(@"PSDP391").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
