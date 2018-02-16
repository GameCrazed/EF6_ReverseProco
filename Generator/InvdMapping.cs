

namespace Generator
{

    public class InvdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Invd>
    {
        public InvdMapping()
            : this("dbo")
        {
        }

        public InvdMapping(string schema)
        {
            ToTable("INVD", schema);
            HasKey(x => x.Invd000);

            Property(x => x.Invd000).HasColumnName(@"INVD000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Invd001).HasColumnName(@"INVD001").HasColumnType("int").IsRequired();
            Property(x => x.Invd005).HasColumnName(@"INVD005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Invd006).HasColumnName(@"INVD006").HasColumnType("int").IsRequired();
            Property(x => x.Invd011).HasColumnName(@"INVD011").HasColumnType("datetime").IsRequired();
            Property(x => x.Invd012).HasColumnName(@"INVD012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Invd015).HasColumnName(@"INVD015").HasColumnType("int").IsRequired();
            Property(x => x.Invd020).HasColumnName(@"INVD020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Invd031).HasColumnName(@"INVD031").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Invd032).HasColumnName(@"INVD032").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Invd033).HasColumnName(@"INVD033").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Invd034).HasColumnName(@"INVD034").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Invd035).HasColumnName(@"INVD035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Invd040).HasColumnName(@"INVD040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Invd045).HasColumnName(@"INVD045").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
        }
    }

}
