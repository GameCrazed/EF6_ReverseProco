

namespace Generator
{

    public class ScvtMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Scvt>
    {
        public ScvtMapping()
            : this("dbo")
        {
        }

        public ScvtMapping(string schema)
        {
            ToTable("SCVT", schema);
            HasKey(x => x.Scvt999);

            Property(x => x.Scvt001).HasColumnName(@"SCVT001").HasColumnType("int").IsRequired();
            Property(x => x.Scvt002).HasColumnName(@"SCVT002").HasColumnType("int").IsRequired();
            Property(x => x.Scvt003).HasColumnName(@"SCVT003").HasColumnType("int").IsRequired();
            Property(x => x.Scvt004).HasColumnName(@"SCVT004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Scvt010).HasColumnName(@"SCVT010").HasColumnType("int").IsRequired();
            Property(x => x.Scvt013).HasColumnName(@"SCVT013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt018).HasColumnName(@"SCVT018").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Scvt102).HasColumnName(@"SCVT102").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Scvt270).HasColumnName(@"SCVT270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Scvt303).HasColumnName(@"SCVT303").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Scvt310).HasColumnName(@"SCVT310").HasColumnType("int").IsRequired();
            Property(x => x.Scvt506).HasColumnName(@"SCVT506").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt999).HasColumnName(@"SCVT999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Scvt110).HasColumnName(@"SCVT110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Scvt020).HasColumnName(@"SCVT020").HasColumnType("int").IsRequired();
            Property(x => x.Scvt600).HasColumnName(@"SCVT600").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt610).HasColumnName(@"SCVT610").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Scvt611).HasColumnName(@"SCVT611").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt612).HasColumnName(@"SCVT612").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt613).HasColumnName(@"SCVT613").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt614).HasColumnName(@"SCVT614").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt615).HasColumnName(@"SCVT615").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Scvt620).HasColumnName(@"SCVT620").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Scvt621).HasColumnName(@"SCVT621").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Scvt622).HasColumnName(@"SCVT622").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Scvt623).HasColumnName(@"SCVT623").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt624).HasColumnName(@"SCVT624").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt630).HasColumnName(@"SCVT630").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Scvt640).HasColumnName(@"SCVT640").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt641).HasColumnName(@"SCVT641").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt642).HasColumnName(@"SCVT642").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt643).HasColumnName(@"SCVT643").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt644).HasColumnName(@"SCVT644").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt645).HasColumnName(@"SCVT645").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt646).HasColumnName(@"SCVT646").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Scvt647).HasColumnName(@"SCVT647").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Scvt650).HasColumnName(@"SCVT650").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt651).HasColumnName(@"SCVT651").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Scvt652).HasColumnName(@"SCVT652").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Scvt653).HasColumnName(@"SCVT653").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Scvt660).HasColumnName(@"SCVT660").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(35);
            Property(x => x.Scvt661).HasColumnName(@"SCVT661").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(11);
            Property(x => x.Scvt662).HasColumnName(@"SCVT662").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(34);
            Property(x => x.Scvt663).HasColumnName(@"SCVT663").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Scvt670).HasColumnName(@"SCVT670").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Scvt671).HasColumnName(@"SCVT671").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt680).HasColumnName(@"SCVT680").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Scvt681).HasColumnName(@"SCVT681").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Scvt682).HasColumnName(@"SCVT682").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Scvt683).HasColumnName(@"SCVT683").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Scvt684).HasColumnName(@"SCVT684").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Scvt685).HasColumnName(@"SCVT685").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Scvt690).HasColumnName(@"SCVT690").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Scvt691).HasColumnName(@"SCVT691").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Scvt692).HasColumnName(@"SCVT692").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Scvt693).HasColumnName(@"SCVT693").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Scvt694).HasColumnName(@"SCVT694").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(29);
            Property(x => x.Scvt695).HasColumnName(@"SCVT695").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Scvt696).HasColumnName(@"SCVT696").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Scvt697).HasColumnName(@"SCVT697").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Scvt698).HasColumnName(@"SCVT698").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Scvt800).HasColumnName(@"SCVT800").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt801).HasColumnName(@"SCVT801").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt802).HasColumnName(@"SCVT802").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt803).HasColumnName(@"SCVT803").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Scvt804).HasColumnName(@"SCVT804").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Scvt805).HasColumnName(@"SCVT805").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Scvt806).HasColumnName(@"SCVT806").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Scvt807).HasColumnName(@"SCVT807").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Scvt808).HasColumnName(@"SCVT808").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Scvt809).HasColumnName(@"SCVT809").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Scvt810).HasColumnName(@"SCVT810").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Scvt811).HasColumnName(@"SCVT811").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Scvt812).HasColumnName(@"SCVT812").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Scvt820).HasColumnName(@"SCVT820").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Scvt821).HasColumnName(@"SCVT821").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Scvt990).HasColumnName(@"SCVT990").HasColumnType("datetime").IsRequired();
            Property(x => x.Scvt991).HasColumnName(@"SCVT991").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Scvt111).HasColumnName(@"SCVT111").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Scvt112).HasColumnName(@"SCVT112").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
