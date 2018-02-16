

namespace Generator
{

    public class IncoMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Inco>
    {
        public IncoMapping()
            : this("dbo")
        {
        }

        public IncoMapping(string schema)
        {
            ToTable("INCO", schema);
            HasKey(x => new { x.Inco001, x.Inco002, x.Inco003 });

            Property(x => x.Inco001).HasColumnName(@"INCO001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Inco002).HasColumnName(@"INCO002").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Inco003).HasColumnName(@"INCO003").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Inco010).HasColumnName(@"INCO010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Inco015).HasColumnName(@"INCO015").HasColumnType("datetime").IsRequired();
            Property(x => x.Inco020).HasColumnName(@"INCO020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Inco999).HasColumnName(@"INCO999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
