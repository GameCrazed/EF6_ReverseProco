

namespace Generator
{

    public class CascMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Casc>
    {
        public CascMapping()
            : this("dbo")
        {
        }

        public CascMapping(string schema)
        {
            ToTable("CASC", schema);
            HasKey(x => new { x.Casc010, x.Casc015, x.Casc025, x.Casc030, x.Casc060 });

            Property(x => x.Casc010).HasColumnName(@"CASC010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Casc015).HasColumnName(@"CASC015").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Casc020).HasColumnName(@"CASC020").HasColumnType("int").IsRequired();
            Property(x => x.Casc025).HasColumnName(@"CASC025").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Casc027).HasColumnName(@"CASC027").HasColumnType("int").IsRequired();
            Property(x => x.Casc030).HasColumnName(@"CASC030").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Casc031).HasColumnName(@"CASC031").HasColumnType("datetime").IsRequired();
            Property(x => x.Casc035).HasColumnName(@"CASC035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Casc040).HasColumnName(@"CASC040").HasColumnType("int").IsRequired();
            Property(x => x.Casc0501).HasColumnName(@"CASC0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc0502).HasColumnName(@"CASC0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc0503).HasColumnName(@"CASC0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc0504).HasColumnName(@"CASC0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc0505).HasColumnName(@"CASC0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc0506).HasColumnName(@"CASC0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc0507).HasColumnName(@"CASC0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc0508).HasColumnName(@"CASC0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc0509).HasColumnName(@"CASC0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc05010).HasColumnName(@"CASC05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc05011).HasColumnName(@"CASC05011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc05012).HasColumnName(@"CASC05012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc060).HasColumnName(@"CASC060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Casc065).HasColumnName(@"CASC065").HasColumnType("int").IsRequired();
            Property(x => x.Casc067).HasColumnName(@"CASC067").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Casc070).HasColumnName(@"CASC070").HasColumnType("datetime").IsRequired();
            Property(x => x.Casc085).HasColumnName(@"CASC085").HasColumnType("datetime").IsRequired();
            Property(x => x.Casc090).HasColumnName(@"CASC090").HasColumnType("datetime").IsRequired();
            Property(x => x.Casc100).HasColumnName(@"CASC100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc110).HasColumnName(@"CASC110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc115).HasColumnName(@"CASC115").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc130).HasColumnName(@"CASC130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc135).HasColumnName(@"CASC135").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc140).HasColumnName(@"CASC140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc200).HasColumnName(@"CASC200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc210).HasColumnName(@"CASC210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc220).HasColumnName(@"CASC220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc225).HasColumnName(@"CASC225").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc230).HasColumnName(@"CASC230").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc235).HasColumnName(@"CASC235").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc240).HasColumnName(@"CASC240").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc300).HasColumnName(@"CASC300").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc310).HasColumnName(@"CASC310").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc320).HasColumnName(@"CASC320").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc325).HasColumnName(@"CASC325").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc330).HasColumnName(@"CASC330").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc335).HasColumnName(@"CASC335").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc340).HasColumnName(@"CASC340").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc400).HasColumnName(@"CASC400").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc410).HasColumnName(@"CASC410").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc420).HasColumnName(@"CASC420").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc425).HasColumnName(@"CASC425").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc430).HasColumnName(@"CASC430").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc435).HasColumnName(@"CASC435").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc440).HasColumnName(@"CASC440").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc500).HasColumnName(@"CASC500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc510).HasColumnName(@"CASC510").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc520).HasColumnName(@"CASC520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc525).HasColumnName(@"CASC525").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc530).HasColumnName(@"CASC530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc535).HasColumnName(@"CASC535").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc540).HasColumnName(@"CASC540").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc600).HasColumnName(@"CASC600").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc610).HasColumnName(@"CASC610").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc620).HasColumnName(@"CASC620").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc625).HasColumnName(@"CASC625").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc630).HasColumnName(@"CASC630").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc635).HasColumnName(@"CASC635").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc640).HasColumnName(@"CASC640").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc700).HasColumnName(@"CASC700").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc710).HasColumnName(@"CASC710").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc720).HasColumnName(@"CASC720").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc725).HasColumnName(@"CASC725").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc730).HasColumnName(@"CASC730").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc735).HasColumnName(@"CASC735").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc740).HasColumnName(@"CASC740").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc870).HasColumnName(@"CASC870").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc880).HasColumnName(@"CASC880").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc885).HasColumnName(@"CASC885").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc900).HasColumnName(@"CASC900").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc910).HasColumnName(@"CASC910").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc915).HasColumnName(@"CASC915").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc930).HasColumnName(@"CASC930").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc940).HasColumnName(@"CASC940").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc950).HasColumnName(@"CASC950").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc955).HasColumnName(@"CASC955").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc960).HasColumnName(@"CASC960").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc961).HasColumnName(@"CASC961").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc963).HasColumnName(@"CASC963").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc965).HasColumnName(@"CASC965").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc966).HasColumnName(@"CASC966").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc968).HasColumnName(@"CASC968").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc969).HasColumnName(@"CASC969").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc970).HasColumnName(@"CASC970").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc971).HasColumnName(@"CASC971").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc975).HasColumnName(@"CASC975").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc977).HasColumnName(@"CASC977").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc979).HasColumnName(@"CASC979").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc980).HasColumnName(@"CASC980").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Casc985).HasColumnName(@"CASC985").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
