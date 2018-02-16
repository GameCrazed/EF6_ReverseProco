

namespace Generator
{

    public class FaudMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Faud>
    {
        public FaudMapping()
            : this("dbo")
        {
        }

        public FaudMapping(string schema)
        {
            ToTable("FAUD", schema);
            HasKey(x => new { x.Faud001, x.Faud002, x.Faud004, x.Faud005 });

            Property(x => x.Faud001).HasColumnName(@"FAUD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Faud002).HasColumnName(@"FAUD002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Faud003).HasColumnName(@"FAUD003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Faud004).HasColumnName(@"FAUD004").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Faud005).HasColumnName(@"FAUD005").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Faud006).HasColumnName(@"FAUD006").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Faud007).HasColumnName(@"FAUD007").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Faud008).HasColumnName(@"FAUD008").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(70);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Fauddtm).HasColumnName(@"FAUDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
