

namespace Generator
{

    public class NbquMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbqu>
    {
        public NbquMapping()
            : this("dbo")
        {
        }

        public NbquMapping(string schema)
        {
            ToTable("NBQU", schema);
            HasKey(x => x.Nbqu999);

            Property(x => x.Nbqu000).HasColumnName(@"NBQU000").HasColumnType("int").IsRequired();
            Property(x => x.Nbqu001).HasColumnName(@"NBQU001").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbqu020).HasColumnName(@"NBQU020").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbqu030).HasColumnName(@"NBQU030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbqu040).HasColumnName(@"NBQU040").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbqu045).HasColumnName(@"NBQU045").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbqu048).HasColumnName(@"NBQU048").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Nbqu050).HasColumnName(@"NBQU050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbqu060).HasColumnName(@"NBQU060").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbqu070).HasColumnName(@"NBQU070").HasColumnType("int").IsRequired();
            Property(x => x.Nbqu080).HasColumnName(@"NBQU080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbqu190).HasColumnName(@"NBQU190").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu191).HasColumnName(@"NBQU191").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu500).HasColumnName(@"NBQU500").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu530).HasColumnName(@"NBQU530").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu535).HasColumnName(@"NBQU535").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu540).HasColumnName(@"NBQU540").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu600).HasColumnName(@"NBQU600").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbqu640).HasColumnName(@"NBQU640").HasColumnType("int").IsRequired();
            Property(x => x.Nbqu800).HasColumnName(@"NBQU800").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu801).HasColumnName(@"NBQU801").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu802).HasColumnName(@"NBQU802").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu803).HasColumnName(@"NBQU803").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu804).HasColumnName(@"NBQU804").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu805).HasColumnName(@"NBQU805").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu806).HasColumnName(@"NBQU806").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu807).HasColumnName(@"NBQU807").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbqu808).HasColumnName(@"NBQU808").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu809).HasColumnName(@"NBQU809").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu810).HasColumnName(@"NBQU810").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu811).HasColumnName(@"NBQU811").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu812).HasColumnName(@"NBQU812").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu813).HasColumnName(@"NBQU813").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu814).HasColumnName(@"NBQU814").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu815).HasColumnName(@"NBQU815").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu816).HasColumnName(@"NBQU816").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu817).HasColumnName(@"NBQU817").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu819).HasColumnName(@"NBQU819").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu820).HasColumnName(@"NBQU820").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu830).HasColumnName(@"NBQU830").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu840).HasColumnName(@"NBQU840").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu850).HasColumnName(@"NBQU850").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbqu999).HasColumnName(@"NBQU999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
