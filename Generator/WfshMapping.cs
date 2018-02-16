

namespace Generator
{

    public class WfshMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Wfsh>
    {
        public WfshMapping()
            : this("dbo")
        {
        }

        public WfshMapping(string schema)
        {
            ToTable("WFSH", schema);
            HasKey(x => new { x.Wfsh010, x.Wfsh080, x.Wfsh020 });

            Property(x => x.Wfsh010).HasColumnName(@"WFSH010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Wfsh020).HasColumnName(@"WFSH020").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Wfsh100).HasColumnName(@"WFSH100").HasColumnType("int").IsRequired();
            Property(x => x.Wfsh130).HasColumnName(@"WFSH130").HasColumnType("int").IsRequired();
            Property(x => x.Wfsh140).HasColumnName(@"WFSH140").HasColumnType("int").IsRequired();
            Property(x => x.Wfsh200).HasColumnName(@"WFSH200").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Wfshdtm).HasColumnName(@"WFSHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Wfsh085).HasColumnName(@"WFSH085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Wfsh080).HasColumnName(@"WFSH080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
