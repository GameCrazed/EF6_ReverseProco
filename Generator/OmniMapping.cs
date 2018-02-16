

namespace Generator
{

    public class OmniMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Omni>
    {
        public OmniMapping()
            : this("dbo")
        {
        }

        public OmniMapping(string schema)
        {
            ToTable("OMNI", schema);
            HasKey(x => x.Omni001);

            Property(x => x.Omni001).HasColumnName(@"OMNI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Omni020).HasColumnName(@"OMNI020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Omni030).HasColumnName(@"OMNI030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Omni040).HasColumnName(@"OMNI040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Omni050).HasColumnName(@"OMNI050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Omni060).HasColumnName(@"OMNI060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Omni070).HasColumnName(@"OMNI070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Omni200).HasColumnName(@"OMNI200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Omni300).HasColumnName(@"OMNI300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Omni400).HasColumnName(@"OMNI400").HasColumnType("tinyint").IsRequired();
            Property(x => x.Omni450).HasColumnName(@"OMNI450").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Omni080).HasColumnName(@"omni080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Omni090).HasColumnName(@"omni090").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Omnidtm).HasColumnName(@"OMNIDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Omni100).HasColumnName(@"OMNI100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Omni500).HasColumnName(@"OMNI500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Omni550).HasColumnName(@"OMNI550").HasColumnType("int").IsRequired();
            Property(x => x.Omni560).HasColumnName(@"OMNI560").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Omni570).HasColumnName(@"OMNI570").HasColumnType("datetime").IsRequired();
            Property(x => x.Omni575).HasColumnName(@"OMNI575").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Omni580).HasColumnName(@"OMNI580").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Omni585).HasColumnName(@"OMNI585").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Omni590).HasColumnName(@"OMNI590").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Omni565).HasColumnName(@"OMNI565").HasColumnType("smallint").IsRequired();
            Property(x => x.Omni110).HasColumnName(@"OMNI110").HasColumnType("datetime").IsRequired();
            Property(x => x.Omni120).HasColumnName(@"OMNI120").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Omni595).HasColumnName(@"OMNI595").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Omni600).HasColumnName(@"OMNI600").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Omni130).HasColumnName(@"OMNI130").HasColumnType("int").IsRequired();
            Property(x => x.Omni017).HasColumnName(@"OMNI017").HasColumnType("datetime").IsRequired();
        }
    }

}
