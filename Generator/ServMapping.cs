

namespace Generator
{

    public class ServMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Serv>
    {
        public ServMapping()
            : this("dbo")
        {
        }

        public ServMapping(string schema)
        {
            ToTable("SERV", schema);
            HasKey(x => new { x.Serv001, x.Serv002 });

            Property(x => x.Serv001).HasColumnName(@"SERV001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Serv002).HasColumnName(@"SERV002").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Serv003).HasColumnName(@"SERV003").HasColumnType("smallint").IsRequired();
            Property(x => x.Serv004).HasColumnName(@"SERV004").HasColumnType("datetime").IsRequired();
            Property(x => x.Serv005).HasColumnName(@"SERV005").HasColumnType("datetime").IsRequired();
        }
    }

}
