

namespace Generator
{

    public class TownMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Town>
    {
        public TownMapping()
            : this("dbo")
        {
        }

        public TownMapping(string schema)
        {
            ToTable("TOWN", schema);
            HasKey(x => x.Town030);

            Property(x => x.Town030).HasColumnName(@"TOWN030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Town040).HasColumnName(@"TOWN040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Town050).HasColumnName(@"TOWN050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Town060).HasColumnName(@"TOWN060").HasColumnType("smallint").IsRequired();
            Property(x => x.Town070).HasColumnName(@"TOWN070").HasColumnType("datetime").IsRequired();
            Property(x => x.Town080).HasColumnName(@"TOWN080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Town090).HasColumnName(@"TOWN090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Town100).HasColumnName(@"TOWN100").HasColumnType("int").IsRequired();
            Property(x => x.Town110).HasColumnName(@"TOWN110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Towndtm).HasColumnName(@"TOWNDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
