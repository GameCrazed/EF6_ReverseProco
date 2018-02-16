

namespace Generator
{

    public class OproMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Opro>
    {
        public OproMapping()
            : this("dbo")
        {
        }

        public OproMapping(string schema)
        {
            ToTable("OPRO", schema);
            HasKey(x => x.Opro001);

            Property(x => x.Opro001).HasColumnName(@"OPRO001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Opro010).HasColumnName(@"OPRO010").HasColumnType("int").IsRequired();
            Property(x => x.Opro013).HasColumnName(@"OPRO013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Opro020).HasColumnName(@"OPRO020").HasColumnType("int").IsRequired();
            Property(x => x.Opro030).HasColumnName(@"OPRO030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Opro040).HasColumnName(@"OPRO040").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Opro050).HasColumnName(@"OPRO050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Opro060).HasColumnName(@"OPRO060").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Opro080).HasColumnName(@"OPRO080").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Opro090).HasColumnName(@"OPRO090").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Opro100).HasColumnName(@"OPRO100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Opro110).HasColumnName(@"OPRO110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Opro120).HasColumnName(@"OPRO120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Oprodtm).HasColumnName(@"OPRODTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
