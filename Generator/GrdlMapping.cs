

namespace Generator
{

    public class GrdlMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Grdl>
    {
        public GrdlMapping()
            : this("dbo")
        {
        }

        public GrdlMapping(string schema)
        {
            ToTable("GRDL", schema);
            HasKey(x => x.Grdl000);

            Property(x => x.Grdl000).HasColumnName(@"GRDL000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Grdl010).HasColumnName(@"GRDL010").HasColumnType("int").IsRequired();
            Property(x => x.Grdl020).HasColumnName(@"GRDL020").HasColumnType("int").IsRequired();
            Property(x => x.Grdl340).HasColumnName(@"GRDL340").HasColumnType("int").IsRequired();
            Property(x => x.Grdl345).HasColumnName(@"GRDL345").HasColumnType("int").IsRequired();
            Property(x => x.Grdl350).HasColumnName(@"GRDL350").HasColumnType("datetime").IsRequired();
            Property(x => x.Grdl355).HasColumnName(@"GRDL355").HasColumnType("smallint").IsRequired();
            Property(x => x.Grdl360).HasColumnName(@"GRDL360").HasColumnType("datetime").IsRequired();
            Property(x => x.Grdl370).HasColumnName(@"GRDL370").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Grdl375).HasColumnName(@"GRDL375").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Grdl380).HasColumnName(@"GRDL380").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Grdl371).HasColumnName(@"GRDL371").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
