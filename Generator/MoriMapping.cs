

namespace Generator
{

    public class MoriMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mori>
    {
        public MoriMapping()
            : this("dbo")
        {
        }

        public MoriMapping(string schema)
        {
            ToTable("MORI", schema);
            HasKey(x => new { x.Mori010, x.Mori020 });

            Property(x => x.Mori010).HasColumnName(@"MORI010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mori020).HasColumnName(@"MORI020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mori030).HasColumnName(@"MORI030").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
        }
    }

}
