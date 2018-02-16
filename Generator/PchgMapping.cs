

namespace Generator
{

    public class PchgMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pchg>
    {
        public PchgMapping()
            : this("dbo")
        {
        }

        public PchgMapping(string schema)
        {
            ToTable("PCHG", schema);
            HasKey(x => new { x.Pchg010, x.Pchg020 });

            Property(x => x.Pchg010).HasColumnName(@"PCHG010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pchg020).HasColumnName(@"PCHG020").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pchg030).HasColumnName(@"PCHG030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Pchg040).HasColumnName(@"PCHG040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pchg050).HasColumnName(@"PCHG050").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pchg060).HasColumnName(@"PCHG060").HasColumnType("int").IsRequired();
            Property(x => x.Pchg070).HasColumnName(@"PCHG070").HasColumnType("int").IsRequired();
            Property(x => x.Pchg080).HasColumnName(@"PCHG080").HasColumnType("smallint").IsRequired();
            Property(x => x.Pchg085).HasColumnName(@"PCHG085").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg087).HasColumnName(@"PCHG087").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pchg090).HasColumnName(@"PCHG090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg095).HasColumnName(@"PCHG095").HasColumnType("tinyint").IsRequired();
            Property(x => x.Pchg120).HasColumnName(@"PCHG120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg130).HasColumnName(@"PCHG130").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg140).HasColumnName(@"PCHG140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg150).HasColumnName(@"PCHG150").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg160).HasColumnName(@"PCHG160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg170).HasColumnName(@"PCHG170").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg180).HasColumnName(@"PCHG180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg190).HasColumnName(@"PCHG190").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg200).HasColumnName(@"PCHG200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg220).HasColumnName(@"PCHG220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg230).HasColumnName(@"PCHG230").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg999).HasColumnName(@"PCHG999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Pchg035).HasColumnName(@"PCHG035").HasColumnType("int").IsRequired();
            Property(x => x.Pchg092).HasColumnName(@"PCHG092").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pchg250).HasColumnName(@"PCHG250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pchg260).HasColumnName(@"PCHG260").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg265).HasColumnName(@"PCHG265").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg270).HasColumnName(@"PCHG270").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg268).HasColumnName(@"PCHG268").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg100).HasColumnName(@"PCHG100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg110).HasColumnName(@"PCHG110").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg145).HasColumnName(@"PCHG145").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Pchg155).HasColumnName(@"PCHG155").HasColumnType("datetime").IsRequired();
            Property(x => x.Pchg262).HasColumnName(@"PCHG262").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
