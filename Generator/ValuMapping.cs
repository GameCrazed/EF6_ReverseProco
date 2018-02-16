

namespace Generator
{

    public class ValuMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Valu>
    {
        public ValuMapping()
            : this("dbo")
        {
        }

        public ValuMapping(string schema)
        {
            ToTable("VALU", schema);
            HasKey(x => x.Valu001);

            Property(x => x.Valu001).HasColumnName(@"VALU001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Valu012).HasColumnName(@"VALU012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Valu014).HasColumnName(@"VALU014").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Valu080).HasColumnName(@"VALU080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Valu090).HasColumnName(@"VALU090").HasColumnType("datetime").IsRequired();
            Property(x => x.Valu100).HasColumnName(@"VALU100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Valu120).HasColumnName(@"VALU120").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Valu070).HasColumnName(@"VALU070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(268);
            Property(x => x.Valu110).HasColumnName(@"VALU110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Valudtm).HasColumnName(@"VALUDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Valu005).HasColumnName(@"VALU005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Valu013).HasColumnName(@"VALU013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Valu030).HasColumnName(@"VALU030").HasColumnType("int").IsRequired();
            Property(x => x.Valu130).HasColumnName(@"VALU130").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Valu140).HasColumnName(@"VALU140").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Valu150).HasColumnName(@"VALU150").HasColumnType("int").IsRequired();
            Property(x => x.Valu160).HasColumnName(@"VALU160").HasColumnType("datetime").IsRequired();
            Property(x => x.Valu170).HasColumnName(@"VALU170").HasColumnType("datetime").IsRequired();
            Property(x => x.Valu180).HasColumnName(@"VALU180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Valu190).HasColumnName(@"VALU190").HasColumnType("datetime").IsRequired();
            Property(x => x.Valu200).HasColumnName(@"VALU200").HasColumnType("datetime").IsRequired();
        }
    }

}
