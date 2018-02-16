

namespace Generator
{

    public class DealMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Deal>
    {
        public DealMapping()
            : this("dbo")
        {
        }

        public DealMapping(string schema)
        {
            ToTable("DEAL", schema);
            HasKey(x => x.Deal999);

            Property(x => x.Deal001).HasColumnName(@"DEAL001").HasColumnType("int").IsRequired();
            Property(x => x.Deal010).HasColumnName(@"DEAL010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Deal020).HasColumnName(@"DEAL020").HasColumnType("int").IsRequired();
            Property(x => x.Deal030).HasColumnName(@"DEAL030").HasColumnType("int").IsRequired();
            Property(x => x.Deal040).HasColumnName(@"DEAL040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Deal050).HasColumnName(@"DEAL050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Deal055).HasColumnName(@"DEAL055").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Deal060).HasColumnName(@"DEAL060").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Deal070).HasColumnName(@"DEAL070").HasColumnType("datetime").IsRequired();
            Property(x => x.Deal080).HasColumnName(@"DEAL080").HasColumnType("datetime").IsRequired();
            Property(x => x.Deal085).HasColumnName(@"DEAL085").HasColumnType("smallint").IsRequired();
            Property(x => x.Deal090).HasColumnName(@"DEAL090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deal100).HasColumnName(@"DEAL100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deal110).HasColumnName(@"DEAL110").HasColumnType("int").IsRequired();
            Property(x => x.Deal120).HasColumnName(@"DEAL120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Deal130).HasColumnName(@"DEAL130").HasColumnType("int").IsRequired();
            Property(x => x.Deal140).HasColumnName(@"DEAL140").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Deal150).HasColumnName(@"DEAL150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deal2001).HasColumnName(@"DEAL2001").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Deal2002).HasColumnName(@"DEAL2002").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Deal2003).HasColumnName(@"DEAL2003").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Deal2004).HasColumnName(@"DEAL2004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Deal2005).HasColumnName(@"DEAL2005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Dealdtm).HasColumnName(@"DEALDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Deal290).HasColumnName(@"DEAL290").HasColumnType("int").IsRequired();
            Property(x => x.Deal999).HasColumnName(@"DEAL999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Deal125).HasColumnName(@"DEAL125").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Deal170).HasColumnName(@"DEAL170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deal180).HasColumnName(@"DEAL180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Deal190).HasColumnName(@"DEAL190").HasColumnType("datetime").IsRequired();
            Property(x => x.Deal195).HasColumnName(@"DEAL195").HasColumnType("smallint").IsRequired();
        }
    }

}
