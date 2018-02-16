

namespace Generator
{

    public class PsdmMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Psdm>
    {
        public PsdmMapping()
            : this("dbo")
        {
        }

        public PsdmMapping(string schema)
        {
            ToTable("PSDM", schema);
            HasKey(x => x.Psdm000);

            Property(x => x.Psdm000).HasColumnName(@"PSDM000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Psdm001).HasColumnName(@"PSDM001").HasColumnType("int").IsRequired();
            Property(x => x.Psdm002).HasColumnName(@"PSDM002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Psdm008).HasColumnName(@"PSDM008").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdm010).HasColumnName(@"PSDM010").HasColumnType("int").IsRequired();
            Property(x => x.Psdm020).HasColumnName(@"PSDM020").HasColumnType("int").IsRequired();
            Property(x => x.Psdm030).HasColumnName(@"PSDM030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm040).HasColumnName(@"PSDM040").HasColumnType("int").IsRequired();
            Property(x => x.Psdm100).HasColumnName(@"PSDM100").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdm110).HasColumnName(@"PSDM110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Psdm120).HasColumnName(@"PSDM120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Psdm130).HasColumnName(@"PSDM130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Psdm140).HasColumnName(@"PSDM140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm150).HasColumnName(@"PSDM150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm160).HasColumnName(@"PSDM160").HasColumnType("int").IsRequired();
            Property(x => x.Psdm170).HasColumnName(@"PSDM170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm180).HasColumnName(@"PSDM180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm190).HasColumnName(@"PSDM190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm200).HasColumnName(@"PSDM200").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdm210).HasColumnName(@"PSDM210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Psdm220).HasColumnName(@"PSDM220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm230).HasColumnName(@"PSDM230").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm240).HasColumnName(@"PSDM240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm250).HasColumnName(@"PSDM250").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm260).HasColumnName(@"PSDM260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Psdm270).HasColumnName(@"PSDM270").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Psdm280).HasColumnName(@"PSDM280").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdm290).HasColumnName(@"PSDM290").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdm015).HasColumnName(@"PSDM015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Psdm016).HasColumnName(@"PSDM016").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdm105).HasColumnName(@"PSDM105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm115).HasColumnName(@"PSDM115").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Psdm116).HasColumnName(@"PSDM116").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(36);
            Property(x => x.Psdm125).HasColumnName(@"PSDM125").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm151).HasColumnName(@"PSDM151").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Psdm152).HasColumnName(@"PSDM152").HasColumnType("int").IsRequired();
            Property(x => x.Psdm153).HasColumnName(@"PSDM153").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm185).HasColumnName(@"PSDM185").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm201).HasColumnName(@"PSDM201").HasColumnType("datetime").IsRequired();
            Property(x => x.Psdm205).HasColumnName(@"PSDM205").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm215).HasColumnName(@"PSDM215").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm221).HasColumnName(@"PSDM221").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm222).HasColumnName(@"PSDM222").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Psdm223).HasColumnName(@"PSDM223").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Psdm241).HasColumnName(@"PSDM241").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm242).HasColumnName(@"PSDM242").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm243).HasColumnName(@"PSDM243").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm244).HasColumnName(@"PSDM244").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm245).HasColumnName(@"PSDM245").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm246).HasColumnName(@"PSDM246").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm247).HasColumnName(@"PSDM247").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm248).HasColumnName(@"PSDM248").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm251).HasColumnName(@"PSDM251").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm255).HasColumnName(@"PSDM255").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm256).HasColumnName(@"PSDM256").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm257).HasColumnName(@"PSDM257").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm258).HasColumnName(@"PSDM258").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm261).HasColumnName(@"PSDM261").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Psdm265).HasColumnName(@"PSDM265").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm266).HasColumnName(@"PSDM266").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm267).HasColumnName(@"PSDM267").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm285).HasColumnName(@"PSDM285").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm300).HasColumnName(@"PSDM300").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm310).HasColumnName(@"PSDM310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm320).HasColumnName(@"PSDM320").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Psdm330).HasColumnName(@"PSDM330").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Psdm340).HasColumnName(@"PSDM340").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm350).HasColumnName(@"PSDM350").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm355).HasColumnName(@"PSDM355").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm360).HasColumnName(@"PSDM360").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm365).HasColumnName(@"PSDM365").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm370).HasColumnName(@"PSDM370").HasColumnType("int").IsRequired();
            Property(x => x.Psdm375).HasColumnName(@"PSDM375").HasColumnType("int").IsRequired();
            Property(x => x.Psdm376).HasColumnName(@"PSDM376").HasColumnType("int").IsRequired();
            Property(x => x.Psdm380).HasColumnName(@"PSDM380").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm385).HasColumnName(@"PSDM385").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm390).HasColumnName(@"PSDM390").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Psdm400).HasColumnName(@"PSDM400").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Psdm410).HasColumnName(@"PSDM410").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Psdm900).HasColumnName(@"PSDM900").HasColumnType("int").IsRequired();
        }
    }

}
