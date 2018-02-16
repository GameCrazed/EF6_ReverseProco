

namespace Generator
{

    public class CuadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cuad>
    {
        public CuadMapping()
            : this("dbo")
        {
        }

        public CuadMapping(string schema)
        {
            ToTable("CUAD", schema);
            HasKey(x => x.Cuad010);

            Property(x => x.Cuad010).HasColumnName(@"CUAD010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cuad020).HasColumnName(@"CUAD020").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad030).HasColumnName(@"CUAD030").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad040).HasColumnName(@"CUAD040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad050).HasColumnName(@"CUAD050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad060).HasColumnName(@"CUAD060").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad070).HasColumnName(@"CUAD070").HasColumnType("int").IsRequired();
            Property(x => x.Cuad080).HasColumnName(@"CUAD080").HasColumnType("int").IsRequired();
            Property(x => x.Cuad090).HasColumnName(@"CUAD090").HasColumnType("int").IsRequired();
            Property(x => x.Cuad120).HasColumnName(@"CUAD120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad130).HasColumnName(@"CUAD130").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad200).HasColumnName(@"CUAD200").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad100).HasColumnName(@"CUAD100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Cuad110).HasColumnName(@"CUAD110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Cuaddtm).HasColumnName(@"CUADDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Cuad021).HasColumnName(@"CUAD021").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad025).HasColumnName(@"CUAD025").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad026).HasColumnName(@"CUAD026").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad051).HasColumnName(@"CUAD051").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad055).HasColumnName(@"CUAD055").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad056).HasColumnName(@"CUAD056").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad061).HasColumnName(@"CUAD061").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad062).HasColumnName(@"CUAD062").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad063).HasColumnName(@"CUAD063").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Cuad065).HasColumnName(@"CUAD065").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad066).HasColumnName(@"CUAD066").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad067).HasColumnName(@"CUAD067").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad068).HasColumnName(@"CUAD068").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Cuad095).HasColumnName(@"CUAD095").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad250).HasColumnName(@"CUAD250").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cuad490).HasColumnName(@"CUAD490").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad500).HasColumnName(@"CUAD500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Cuad520).HasColumnName(@"CUAD520").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Cuad041).HasColumnName(@"CUAD041").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad064).HasColumnName(@"CUAD064").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad069).HasColumnName(@"CUAD069").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad071).HasColumnName(@"CUAD071").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad072).HasColumnName(@"CUAD072").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad073).HasColumnName(@"CUAD073").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad260).HasColumnName(@"CUAD260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad600).HasColumnName(@"CUAD600").HasColumnType("int").IsRequired();
            Property(x => x.Cuad270).HasColumnName(@"CUAD270").HasColumnType("int").IsRequired();
            Property(x => x.Cuad280).HasColumnName(@"CUAD280").HasColumnType("int").IsRequired();
            Property(x => x.Cuad290).HasColumnName(@"CUAD290").HasColumnType("int").IsRequired();
            Property(x => x.Cuad285).HasColumnName(@"CUAD285").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad265).HasColumnName(@"CUAD265").HasColumnType("smallint").IsRequired();
            Property(x => x.Cuad266).HasColumnName(@"CUAD266").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Cuad300).HasColumnName(@"CUAD300").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad305).HasColumnName(@"CUAD305").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad310).HasColumnName(@"CUAD310").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cuad315).HasColumnName(@"CUAD315").HasColumnType("int").IsRequired();
            Property(x => x.Cuad301).HasColumnName(@"CUAD301").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad304).HasColumnName(@"CUAD304").HasColumnType("datetime").IsRequired();
            Property(x => x.Cuad210).HasColumnName(@"CUAD210").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad220).HasColumnName(@"CUAD220").HasColumnType("tinyint").IsRequired();
            Property(x => x.Cuad022).HasColumnName(@"CUAD022").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad076).HasColumnName(@"CUAD076").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cuad400).HasColumnName(@"CUAD400").HasColumnType("int").IsRequired();
            Property(x => x.Cuad402).HasColumnName(@"CUAD402").HasColumnType("int").IsRequired();
            Property(x => x.Cuad205).HasColumnName(@"CUAD205").HasColumnType("datetime").IsRequired();
        }
    }

}
