

namespace Generator
{

    public class PothMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Poth>
    {
        public PothMapping()
            : this("dbo")
        {
        }

        public PothMapping(string schema)
        {
            ToTable("POTH", schema);
            HasKey(x => x.Poth001);

            Property(x => x.Poth001).HasColumnName(@"POTH001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Poth010).HasColumnName(@"POTH010").HasColumnType("int").IsRequired();
            Property(x => x.Poth020).HasColumnName(@"POTH020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Poth053).HasColumnName(@"POTH053").HasColumnType("smallint").IsRequired();
            Property(x => x.Poth055).HasColumnName(@"POTH055").HasColumnType("int").IsRequired();
            Property(x => x.Poth056).HasColumnName(@"POTH056").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Poth064).HasColumnName(@"POTH064").HasColumnType("int").IsRequired();
            Property(x => x.Poth100).HasColumnName(@"POTH100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Poth110).HasColumnName(@"POTH110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Poth120).HasColumnName(@"POTH120").HasColumnType("int").IsRequired();
            Property(x => x.Poth140).HasColumnName(@"POTH140").HasColumnType("datetime").IsRequired();
        }
    }

}
