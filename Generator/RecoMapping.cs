

namespace Generator
{

    public class RecoMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Reco>
    {
        public RecoMapping()
            : this("dbo")
        {
        }

        public RecoMapping(string schema)
        {
            ToTable("RECO", schema);
            HasKey(x => x.Reco001);

            Property(x => x.Reco001).HasColumnName(@"RECO001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Reco060).HasColumnName(@"RECO060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Reco070).HasColumnName(@"RECO070").HasColumnType("datetime").IsRequired();
            Property(x => x.Reco080).HasColumnName(@"RECO080").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Reco090).HasColumnName(@"RECO090").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Reco100).HasColumnName(@"RECO100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Reco110).HasColumnName(@"RECO110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Reco120).HasColumnName(@"RECO120").HasColumnType("datetime").IsRequired();
        }
    }

}
