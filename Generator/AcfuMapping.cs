

namespace Generator
{

    public class AcfuMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acfu>
    {
        public AcfuMapping()
            : this("dbo")
        {
        }

        public AcfuMapping(string schema)
        {
            ToTable("ACFU", schema);
            HasKey(x => x.Acfu999);

            Property(x => x.Acfu010).HasColumnName(@"ACFU010").HasColumnType("datetime").IsRequired();
            Property(x => x.Acfu020).HasColumnName(@"ACFU020").HasColumnType("int").IsRequired();
            Property(x => x.Acfu030).HasColumnName(@"ACFU030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acfu040).HasColumnName(@"ACFU040").HasColumnType("datetime").IsRequired();
            Property(x => x.Acfu050).HasColumnName(@"ACFU050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acfu060).HasColumnName(@"ACFU060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acfu070).HasColumnName(@"ACFU070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Acfu080).HasColumnName(@"ACFU080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acfu085).HasColumnName(@"ACFU085").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acfu090).HasColumnName(@"ACFU090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acfu200).HasColumnName(@"ACFU200").HasColumnType("int").IsRequired();
            Property(x => x.Acfu999).HasColumnName(@"ACFU999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Acfu100).HasColumnName(@"ACFU100").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Acfudtm).HasColumnName(@"ACFUDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Acfu035).HasColumnName(@"ACFU035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acfu037).HasColumnName(@"ACFU037").HasColumnType("int").IsRequired();
            Property(x => x.Acfu055).HasColumnName(@"ACFU055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Acfu210).HasColumnName(@"ACFU210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acfu220).HasColumnName(@"ACFU220").HasColumnType("datetime").IsRequired();
            Property(x => x.Acfu230).HasColumnName(@"ACFU230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acfu250).HasColumnName(@"ACFU250").HasColumnType("datetime").IsRequired();
            Property(x => x.Acfu240).HasColumnName(@"ACFU240").HasColumnType("tinyint").IsRequired();
        }
    }

}
