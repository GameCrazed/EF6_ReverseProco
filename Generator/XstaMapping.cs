

namespace Generator
{

    public class XstaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Xsta>
    {
        public XstaMapping()
            : this("dbo")
        {
        }

        public XstaMapping(string schema)
        {
            ToTable("XSTA", schema);
            HasKey(x => x.Xsta010);

            Property(x => x.Xsta010).HasColumnName(@"XSTA010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xsta020).HasColumnName(@"XSTA020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Xsta0301).HasColumnName(@"XSTA0301").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xsta0302).HasColumnName(@"XSTA0302").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xsta0303).HasColumnName(@"XSTA0303").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xsta0401).HasColumnName(@"XSTA0401").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta0402).HasColumnName(@"XSTA0402").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta0403).HasColumnName(@"XSTA0403").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta0404).HasColumnName(@"XSTA0404").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta0405).HasColumnName(@"XSTA0405").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta0406).HasColumnName(@"XSTA0406").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta0407).HasColumnName(@"XSTA0407").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta0408).HasColumnName(@"XSTA0408").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta0409).HasColumnName(@"XSTA0409").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta04010).HasColumnName(@"XSTA04010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta041).HasColumnName(@"XSTA041").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Xsta042).HasColumnName(@"XSTA042").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta050).HasColumnName(@"XSTA050").HasColumnType("int").IsRequired();
            Property(x => x.Xsta052).HasColumnName(@"XSTA052").HasColumnType("int").IsRequired();
            Property(x => x.Xsta053).HasColumnName(@"XSTA053").HasColumnType("int").IsRequired();
            Property(x => x.Xsta054).HasColumnName(@"XSTA054").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xsta060).HasColumnName(@"XSTA060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Xsta070).HasColumnName(@"XSTA070").HasColumnType("smallint").IsRequired();
            Property(x => x.Xsta100).HasColumnName(@"XSTA100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Xsta120).HasColumnName(@"XSTA120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Xsta150).HasColumnName(@"XSTA150").HasColumnType("int").IsRequired();
            Property(x => x.Xsta151).HasColumnName(@"XSTA151").HasColumnType("int").IsRequired();
            Property(x => x.Xsta152).HasColumnName(@"XSTA152").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Xsta160).HasColumnName(@"XSTA160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Xsta170).HasColumnName(@"XSTA170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Xsta180).HasColumnName(@"XSTA180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xsta055).HasColumnName(@"XSTA055").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xsta056).HasColumnName(@"XSTA056").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Xsta200).HasColumnName(@"XSTA200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Xstadtm).HasColumnName(@"XSTADTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Xsta220).HasColumnName(@"XSTA220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Xsta065).HasColumnName(@"XSTA065").HasColumnType("int").IsRequired();
            Property(x => x.Xsta190).HasColumnName(@"XSTA190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Xsta000).HasColumnName(@"XSTA000").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Xsta005).HasColumnName(@"XSTA005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Xsta006).HasColumnName(@"XSTA006").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta061).HasColumnName(@"XSTA061").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Xsta080).HasColumnName(@"XSTA080").HasColumnType("smallint").IsRequired();
            Property(x => x.Xsta230).HasColumnName(@"XSTA230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Xsta400).HasColumnName(@"XSTA400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Xsta081).HasColumnName(@"XSTA081").HasColumnType("smallint").IsRequired();
            Property(x => x.Xsta082).HasColumnName(@"XSTA082").HasColumnType("smallint").IsRequired();
            Property(x => x.Xsta083).HasColumnName(@"XSTA083").HasColumnType("smallint").IsRequired();
            Property(x => x.Xsta084).HasColumnName(@"XSTA084").HasColumnType("smallint").IsRequired();
            Property(x => x.Xsta087).HasColumnName(@"XSTA087").HasColumnType("smallint").IsRequired();
            Property(x => x.Xsta043).HasColumnName(@"XSTA043").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Xsta045).HasColumnName(@"XSTA045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Xsta001).HasColumnName(@"XSTA001").HasColumnType("int").IsRequired();
            Property(x => x.Xsta221).HasColumnName(@"XSTA221").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xsta225).HasColumnName(@"XSTA225").HasColumnType("int").IsRequired();
            Property(x => x.Xsta240).HasColumnName(@"XSTA240").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Xsta226).HasColumnName(@"XSTA226").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(36);
            Property(x => x.Xsta222).HasColumnName(@"XSTA222").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Xsta227).HasColumnName(@"XSTA227").HasColumnType("datetime").IsRequired();
            Property(x => x.Xsta228).HasColumnName(@"XSTA228").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Xsta250).HasColumnName(@"XSTA250").HasColumnType("tinyint").IsRequired();
            Property(x => x.Xsta251).HasColumnName(@"XSTA251").HasColumnType("int").IsRequired();
            Property(x => x.Xsta252).HasColumnName(@"XSTA252").HasColumnType("int").IsRequired();
            Property(x => x.Xsta253).HasColumnName(@"XSTA253").HasColumnType("datetime").IsRequired();
            Property(x => x.Xsta410).HasColumnName(@"XSTA410").HasColumnType("int").IsRequired();
        }
    }

}
