

namespace Generator
{

    public class NbpeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbpe>
    {
        public NbpeMapping()
            : this("dbo")
        {
        }

        public NbpeMapping(string schema)
        {
            ToTable("NBPE", schema);
            HasKey(x => x.Nbpe999);

            Property(x => x.Nbpe001).HasColumnName(@"NBPE001").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe010).HasColumnName(@"NBPE010").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbpe015).HasColumnName(@"NBPE015").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe016).HasColumnName(@"NBPE016").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbpe018).HasColumnName(@"NBPE018").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe020).HasColumnName(@"NBPE020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe025).HasColumnName(@"NBPE025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbpe030).HasColumnName(@"NBPE030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe040).HasColumnName(@"NBPE040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe050).HasColumnName(@"NBPE050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Nbpe060).HasColumnName(@"NBPE060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Nbpe070).HasColumnName(@"NBPE070").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbpe075).HasColumnName(@"NBPE075").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbpe080).HasColumnName(@"NBPE080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe090).HasColumnName(@"NBPE090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe097).HasColumnName(@"NBPE097").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbpe100).HasColumnName(@"NBPE100").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbpe110).HasColumnName(@"NBPE110").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbpe115).HasColumnName(@"NBPE115").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbpe120).HasColumnName(@"NBPE120").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbpe130).HasColumnName(@"NBPE130").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbpe140).HasColumnName(@"NBPE140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbpe150).HasColumnName(@"NBPE150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe155).HasColumnName(@"NBPE155").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe160).HasColumnName(@"NBPE160").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbpe170).HasColumnName(@"NBPE170").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbpe180).HasColumnName(@"NBPE180").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbpe200).HasColumnName(@"NBPE200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbpe210).HasColumnName(@"NBPE210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbpe240).HasColumnName(@"NBPE240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe300).HasColumnName(@"NBPE300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Nbpe310).HasColumnName(@"NBPE310").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe350).HasColumnName(@"NBPE350").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe365).HasColumnName(@"NBPE365").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbpe450).HasColumnName(@"NBPE450").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Nbpe455).HasColumnName(@"NBPE455").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe460).HasColumnName(@"NBPE460").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe462).HasColumnName(@"NBPE462").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(45);
            Property(x => x.Nbpe465).HasColumnName(@"NBPE465").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe470).HasColumnName(@"NBPE470").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe740).HasColumnName(@"NBPE740").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe742).HasColumnName(@"NBPE742").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe745).HasColumnName(@"NBPE745").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Nbpe747).HasColumnName(@"NBPE747").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbpe999).HasColumnName(@"NBPE999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbpe091).HasColumnName(@"NBPE091").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe093).HasColumnName(@"NBPE093").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe095).HasColumnName(@"NBPE095").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe096).HasColumnName(@"NBPE096").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe360).HasColumnName(@"NBPE360").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe370).HasColumnName(@"NBPE370").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbpe375).HasColumnName(@"NBPE375").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpe400).HasColumnName(@"NBPE400").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe401).HasColumnName(@"NBPE401").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe405).HasColumnName(@"NBPE405").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe410).HasColumnName(@"NBPE410").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe411).HasColumnName(@"NBPE411").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe412).HasColumnName(@"NBPE412").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe413).HasColumnName(@"NBPE413").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpe414).HasColumnName(@"NBPE414").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbpe535).HasColumnName(@"NBPE535").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbpe990).HasColumnName(@"NBPE990").HasColumnType("int").IsRequired();
            Property(x => x.Nbpe017).HasColumnName(@"NBPE017").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbpe995).HasColumnName(@"NBPE995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
