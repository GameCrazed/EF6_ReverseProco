

namespace Generator
{

    public class NbinMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbin>
    {
        public NbinMapping()
            : this("dbo")
        {
        }

        public NbinMapping(string schema)
        {
            ToTable("NBIN", schema);
            HasKey(x => x.Nbin999);

            Property(x => x.Nbin001).HasColumnName(@"NBIN001").HasColumnType("int").IsRequired();
            Property(x => x.Nbin002).HasColumnName(@"NBIN002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbin003).HasColumnName(@"NBIN003").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbin005).HasColumnName(@"NBIN005").HasColumnType("int").IsRequired();
            Property(x => x.Nbin008).HasColumnName(@"NBIN008").HasColumnType("int").IsRequired();
            Property(x => x.Nbin010).HasColumnName(@"NBIN010").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbin020).HasColumnName(@"NBIN020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbin030).HasColumnName(@"NBIN030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Nbin040).HasColumnName(@"NBIN040").HasColumnType("int").IsRequired();
            Property(x => x.Nbin050).HasColumnName(@"NBIN050").HasColumnType("int").IsRequired();
            Property(x => x.Nbin060).HasColumnName(@"NBIN060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbin065).HasColumnName(@"NBIN065").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbin070).HasColumnName(@"NBIN070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin080).HasColumnName(@"NBIN080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin085).HasColumnName(@"NBIN085").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin090).HasColumnName(@"NBIN090").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin100).HasColumnName(@"NBIN100").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin160).HasColumnName(@"NBIN160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbin170).HasColumnName(@"NBIN170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin175).HasColumnName(@"NBIN175").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin200).HasColumnName(@"NBIN200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbin230).HasColumnName(@"NBIN230").HasColumnType("int").IsRequired();
            Property(x => x.Nbin300).HasColumnName(@"NBIN300").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin310).HasColumnName(@"NBIN310").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin330).HasColumnName(@"NBIN330").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbin350).HasColumnName(@"NBIN350").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin355).HasColumnName(@"NBIN355").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin400).HasColumnName(@"NBIN400").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin500).HasColumnName(@"NBIN500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Nbin510).HasColumnName(@"NBIN510").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbin520).HasColumnName(@"NBIN520").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin530).HasColumnName(@"NBIN530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin540).HasColumnName(@"NBIN540").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Nbin550).HasColumnName(@"NBIN550").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbin560).HasColumnName(@"NBIN560").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin565).HasColumnName(@"NBIN565").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin570).HasColumnName(@"NBIN570").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin580).HasColumnName(@"NBIN580").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin590).HasColumnName(@"NBIN590").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbin999).HasColumnName(@"NBIN999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbin215).HasColumnName(@"NBIN215").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(41);
            Property(x => x.Nbin315).HasColumnName(@"NBIN315").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbin515).HasColumnName(@"NBIN515").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(40);
        }
    }

}
