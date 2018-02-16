

namespace Generator
{

    public class SpcnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Spcn>
    {
        public SpcnMapping()
            : this("dbo")
        {
        }

        public SpcnMapping(string schema)
        {
            ToTable("SPCN", schema);
            HasKey(x => x.Spcn000);

            Property(x => x.Spcn000).HasColumnName(@"SPCN000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Spcn001).HasColumnName(@"SPCN001").HasColumnType("int").IsRequired();
            Property(x => x.Spcn011).HasColumnName(@"SPCN011").HasColumnType("datetime").IsRequired();
            Property(x => x.Spcn012).HasColumnName(@"SPCN012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Spcn015).HasColumnName(@"SPCN015").HasColumnType("tinyint").IsRequired();
            Property(x => x.Spcn020).HasColumnName(@"SPCN020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Spcn030).HasColumnName(@"SPCN030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Spcn040).HasColumnName(@"SPCN040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Spcn050).HasColumnName(@"SPCN050").HasColumnType("datetime").IsRequired();
            Property(x => x.Spcn055).HasColumnName(@"SPCN055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Spcn060).HasColumnName(@"SPCN060").HasColumnType("datetime").IsRequired();
            Property(x => x.Spcn080).HasColumnName(@"SPCN080").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(90);
            Property(x => x.Spcn100).HasColumnName(@"SPCN100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Spcndtm).HasColumnName(@"SPCNDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
