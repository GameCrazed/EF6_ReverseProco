

namespace Generator
{

    public class AcidMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acid>
    {
        public AcidMapping()
            : this("dbo")
        {
        }

        public AcidMapping(string schema)
        {
            ToTable("ACID", schema);
            HasKey(x => new { x.Acid010, x.Acid020 });

            Property(x => x.Acid010).HasColumnName(@"ACID010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acid020).HasColumnName(@"ACID020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acid030).HasColumnName(@"ACID030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Acid040).HasColumnName(@"ACID040").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acid050).HasColumnName(@"ACID050").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acid060).HasColumnName(@"ACID060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acid070).HasColumnName(@"ACID070").HasColumnType("int").IsRequired();
            Property(x => x.Acid080).HasColumnName(@"ACID080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acid090).HasColumnName(@"ACID090").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acid100).HasColumnName(@"ACID100").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acid110).HasColumnName(@"ACID110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acid120).HasColumnName(@"ACID120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acid140).HasColumnName(@"ACID140").HasColumnType("datetime").IsRequired();
            Property(x => x.Acid150).HasColumnName(@"ACID150").HasColumnType("datetime").IsRequired();
            Property(x => x.Acid752).HasColumnName(@"ACID752").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acid754).HasColumnName(@"ACID754").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acid758).HasColumnName(@"ACID758").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acid760).HasColumnName(@"ACID760").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acid812).HasColumnName(@"ACID812").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acid816).HasColumnName(@"ACID816").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Aciddtm).HasColumnName(@"ACIDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
