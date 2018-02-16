

namespace Generator
{

    public class DepnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Depn>
    {
        public DepnMapping()
            : this("dbo")
        {
        }

        public DepnMapping(string schema)
        {
            ToTable("DEPN", schema);
            HasKey(x => x.Depn001);

            Property(x => x.Depn001).HasColumnName(@"DEPN001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Depn010).HasColumnName(@"DEPN010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Depn020).HasColumnName(@"DEPN020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Depn030).HasColumnName(@"DEPN030").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Depn040).HasColumnName(@"DEPN040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Depn050).HasColumnName(@"DEPN050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Depn060).HasColumnName(@"DEPN060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Depn070).HasColumnName(@"DEPN070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Depn080).HasColumnName(@"DEPN080").HasColumnType("int").IsRequired();
            Property(x => x.Depn200).HasColumnName(@"DEPN200").HasColumnType("datetime").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Depndtm).HasColumnName(@"DEPNDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Depn090).HasColumnName(@"DEPN090").HasColumnType("int").IsRequired();
            Property(x => x.Depn100).HasColumnName(@"DEPN100").HasColumnType("datetime").IsRequired();
        }
    }

}
