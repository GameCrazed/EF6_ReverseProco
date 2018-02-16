

namespace Generator
{

    public class PostMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Post>
    {
        public PostMapping()
            : this("dbo")
        {
        }

        public PostMapping(string schema)
        {
            ToTable("POST", schema);
            HasKey(x => x.Post000);

            Property(x => x.Post000).HasColumnName(@"POST000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Post001).HasColumnName(@"POST001").HasColumnType("int").IsRequired();
            Property(x => x.Post005).HasColumnName(@"POST005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Post010).HasColumnName(@"POST010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Post011).HasColumnName(@"POST011").HasColumnType("datetime").IsRequired();
            Property(x => x.Post012).HasColumnName(@"POST012").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Post015).HasColumnName(@"POST015").HasColumnType("int").IsRequired();
            Property(x => x.Post020).HasColumnName(@"POST020").HasColumnType("datetime").IsRequired();
            Property(x => x.Post030).HasColumnName(@"POST030").HasColumnType("datetime").IsRequired();
            Property(x => x.Post035).HasColumnName(@"POST035").HasColumnType("smallint").IsRequired();
            Property(x => x.Post040).HasColumnName(@"POST040").HasColumnType("datetime").IsRequired();
            Property(x => x.Post045).HasColumnName(@"POST045").HasColumnType("smallint").IsRequired();
            Property(x => x.Post050).HasColumnName(@"POST050").HasColumnType("int").IsRequired();
            Property(x => x.Post100).HasColumnName(@"POST100").HasColumnType("int").IsRequired();
            Property(x => x.Post190).HasColumnName(@"POST190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Post200).HasColumnName(@"POST200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Post205).HasColumnName(@"POST205").HasColumnType("int").IsRequired();
            Property(x => x.Post210).HasColumnName(@"POST210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Post500).HasColumnName(@"POST500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(500);
        }
    }

}
