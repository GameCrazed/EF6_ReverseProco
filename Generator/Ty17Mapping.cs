

namespace Generator
{

    public class Ty17Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty17>
    {
        public Ty17Mapping()
            : this("dbo")
        {
        }

        public Ty17Mapping(string schema)
        {
            ToTable("TY17", schema);
            HasKey(x => x.Ty17001);

            Property(x => x.Ty17001).HasColumnName(@"TY17001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty17010).HasColumnName(@"TY17010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty17100).HasColumnName(@"TY17100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty17200).HasColumnName(@"TY17200").HasColumnType("int").IsRequired();
        }
    }

}
