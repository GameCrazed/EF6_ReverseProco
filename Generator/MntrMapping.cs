

namespace Generator
{

    public class MntrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mntr>
    {
        public MntrMapping()
            : this("dbo")
        {
        }

        public MntrMapping(string schema)
        {
            ToTable("MNTR", schema);
            HasKey(x => x.Mntr010);

            Property(x => x.Mntr010).HasColumnName(@"MNTR010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mntr030).HasColumnName(@"MNTR030").HasColumnType("int").IsRequired();
            Property(x => x.Mntr050).HasColumnName(@"MNTR050").HasColumnType("int").IsRequired();
            Property(x => x.Mntr055).HasColumnName(@"MNTR055").HasColumnType("int").IsRequired();
            Property(x => x.Mntr060).HasColumnName(@"MNTR060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr070).HasColumnName(@"MNTR070").HasColumnType("smallint").IsRequired();
            Property(x => x.Mntr080).HasColumnName(@"MNTR080").HasColumnType("int").IsRequired();
            Property(x => x.Mntr090).HasColumnName(@"MNTR090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mntr100).HasColumnName(@"MNTR100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mntr110).HasColumnName(@"MNTR110").HasColumnType("datetime").IsRequired();
            Property(x => x.Mntr120).HasColumnName(@"MNTR120").HasColumnType("datetime").IsRequired();
            Property(x => x.Mntr130).HasColumnName(@"MNTR130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Mntr140).HasColumnName(@"MNTR140").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr210).HasColumnName(@"MNTR210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Mntr231).HasColumnName(@"MNTR231").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mntr240).HasColumnName(@"MNTR240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Mntr250).HasColumnName(@"MNTR250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Mntr260).HasColumnName(@"MNTR260").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mntr270).HasColumnName(@"MNTR270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mntr280).HasColumnName(@"MNTR280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Mntr040).HasColumnName(@"MNTR040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Mntrdtm).HasColumnName(@"MNTRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Mntr290).HasColumnName(@"MNTR290").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Mntr150).HasColumnName(@"MNTR150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Mntr501).HasColumnName(@"MNTR501").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr502).HasColumnName(@"MNTR502").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr503).HasColumnName(@"MNTR503").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr504).HasColumnName(@"MNTR504").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr505).HasColumnName(@"MNTR505").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr506).HasColumnName(@"MNTR506").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr507).HasColumnName(@"MNTR507").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr508).HasColumnName(@"MNTR508").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mntr550).HasColumnName(@"MNTR550").HasColumnType("smallint").IsRequired();
            Property(x => x.Mntr600).HasColumnName(@"MNTR600").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.Mntr300).HasColumnName(@"MNTR300").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Mntr131).HasColumnName(@"MNTR131").HasColumnType("int").IsRequired();
            Property(x => x.Mntr132).HasColumnName(@"MNTR132").HasColumnType("datetime").IsRequired();
        }
    }

}
