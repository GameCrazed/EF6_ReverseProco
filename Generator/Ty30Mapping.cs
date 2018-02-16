

namespace Generator
{

    public class Ty30Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty30>
    {
        public Ty30Mapping()
            : this("dbo")
        {
        }

        public Ty30Mapping(string schema)
        {
            ToTable("TY30", schema);
            HasKey(x => x.Ty30001);

            Property(x => x.Ty30001).HasColumnName(@"TY30001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty30010).HasColumnName(@"TY30010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ty30100).HasColumnName(@"TY30100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty30200).HasColumnName(@"TY30200").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty30400).HasColumnName(@"TY30400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty30500).HasColumnName(@"TY30500").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty30600).HasColumnName(@"TY30600").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty30700).HasColumnName(@"TY30700").HasColumnType("tinyint").IsRequired();
            Property(x => x.Ty30800).HasColumnName(@"TY30800").HasColumnType("datetime").IsRequired();
            Property(x => x.Ty30900).HasColumnName(@"TY30900").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
