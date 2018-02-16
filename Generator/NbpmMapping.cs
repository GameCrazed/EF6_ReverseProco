

namespace Generator
{

    public class NbpmMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbpm>
    {
        public NbpmMapping()
            : this("dbo")
        {
        }

        public NbpmMapping(string schema)
        {
            ToTable("NBPM", schema);
            HasKey(x => x.Nbpm999);

            Property(x => x.Nbpm001).HasColumnName(@"NBPM001").HasColumnType("int").IsRequired();
            Property(x => x.Nbpm010).HasColumnName(@"NBPM010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpm015).HasColumnName(@"NBPM015").HasColumnType("int").IsRequired();
            Property(x => x.Nbpm020).HasColumnName(@"NBPM020").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbpm030).HasColumnName(@"NBPM030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpm040).HasColumnName(@"NBPM040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbpm050).HasColumnName(@"NBPM050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbpm060).HasColumnName(@"NBPM060").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbpm065).HasColumnName(@"NBPM065").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbpm070).HasColumnName(@"NBPM070").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbpm080).HasColumnName(@"NBPM080").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbpm160).HasColumnName(@"NBPM160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbpm999).HasColumnName(@"NBPM999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbpm180).HasColumnName(@"NBPM180").HasColumnType("int").IsRequired();
            Property(x => x.Nbpm150).HasColumnName(@"NBPM150").HasColumnType("tinyint").IsRequired();
        }
    }

}
