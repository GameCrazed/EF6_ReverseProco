

namespace Generator
{

    public class ScorMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Scor>
    {
        public ScorMapping()
            : this("dbo")
        {
        }

        public ScorMapping(string schema)
        {
            ToTable("SCOR", schema);
            HasKey(x => x.Scor001);

            Property(x => x.Scor001).HasColumnName(@"SCOR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Scor010).HasColumnName(@"SCOR010").HasColumnType("datetime").IsRequired();
            Property(x => x.Scor011).HasColumnName(@"SCOR011").HasColumnType("int").IsRequired();
            Property(x => x.Scor012).HasColumnName(@"SCOR012").HasColumnType("int").IsRequired();
            Property(x => x.Scor013).HasColumnName(@"SCOR013").HasColumnType("int").IsRequired();
            Property(x => x.Scor014).HasColumnName(@"SCOR014").HasColumnType("int").IsRequired();
            Property(x => x.Scor015).HasColumnName(@"SCOR015").HasColumnType("int").IsRequired();
            Property(x => x.Scor020).HasColumnName(@"SCOR020").HasColumnType("int").IsRequired();
        }
    }

}
