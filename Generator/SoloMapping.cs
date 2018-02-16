

namespace Generator
{

    public class SoloMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Solo>
    {
        public SoloMapping()
            : this("dbo")
        {
        }

        public SoloMapping(string schema)
        {
            ToTable("SOLI", schema);
            HasKey(x => x.Soli001);

            Property(x => x.Soli001).HasColumnName(@"SOLI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Soli0501).HasColumnName(@"SOLI0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0502).HasColumnName(@"SOLI0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0503).HasColumnName(@"SOLI0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0504).HasColumnName(@"SOLI0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0505).HasColumnName(@"SOLI0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0506).HasColumnName(@"SOLI0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0507).HasColumnName(@"SOLI0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0508).HasColumnName(@"SOLI0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0509).HasColumnName(@"SOLI0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli05010).HasColumnName(@"SOLI05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Soli0601).HasColumnName(@"SOLI0601").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli0602).HasColumnName(@"SOLI0602").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli0603).HasColumnName(@"SOLI0603").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli0604).HasColumnName(@"SOLI0604").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli0605).HasColumnName(@"SOLI0605").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli0606).HasColumnName(@"SOLI0606").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli0607).HasColumnName(@"SOLI0607").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli0608).HasColumnName(@"SOLI0608").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli0609).HasColumnName(@"SOLI0609").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli06010).HasColumnName(@"SOLI06010").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Soli200).HasColumnName(@"SOLI200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Solidtm).HasColumnName(@"SOLIDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
