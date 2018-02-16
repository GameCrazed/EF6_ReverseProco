

namespace Generator
{

    public class MapxMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mapx>
    {
        public MapxMapping()
            : this("dbo")
        {
        }

        public MapxMapping(string schema)
        {
            ToTable("MAPX", schema);
            HasKey(x => new { x.Mapx001, x.Mapx002 });

            Property(x => x.Mapx001).HasColumnName(@"MAPX001").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mapx002).HasColumnName(@"MAPX002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mapx003).HasColumnName(@"MAPX003").HasColumnType("int").IsRequired();
            Property(x => x.Mapx004).HasColumnName(@"MAPX004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Mapx015).HasColumnName(@"MAPX015").HasColumnType("int").IsRequired();
        }
    }

}
