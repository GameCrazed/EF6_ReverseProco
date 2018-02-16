

namespace Generator
{

    public class CsitMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Csit>
    {
        public CsitMapping()
            : this("dbo")
        {
        }

        public CsitMapping(string schema)
        {
            ToTable("CSIT", schema);
            HasKey(x => x.Csit5101);

            Property(x => x.Csit5101).HasColumnName(@"CSIT5101").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Csit5102).HasColumnName(@"CSIT5102").HasColumnType("int").IsRequired();
            Property(x => x.Csit5103).HasColumnName(@"CSIT5103").HasColumnType("int").IsRequired();
            Property(x => x.Csit5104).HasColumnName(@"CSIT5104").HasColumnType("int").IsRequired();
            Property(x => x.Csit5105).HasColumnName(@"CSIT5105").HasColumnType("int").IsRequired();
            Property(x => x.Csit5106).HasColumnName(@"CSIT5106").HasColumnType("int").IsRequired();
            Property(x => x.Csit5107).HasColumnName(@"CSIT5107").HasColumnType("int").IsRequired();
            Property(x => x.Csit5108).HasColumnName(@"CSIT5108").HasColumnType("int").IsRequired();
            Property(x => x.Csit5109).HasColumnName(@"CSIT5109").HasColumnType("int").IsRequired();
            Property(x => x.Csit51010).HasColumnName(@"CSIT51010").HasColumnType("int").IsRequired();
        }
    }

}
