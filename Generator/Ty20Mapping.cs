

namespace Generator
{

    public class Ty20Mapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ty20>
    {
        public Ty20Mapping()
            : this("dbo")
        {
        }

        public Ty20Mapping(string schema)
        {
            ToTable("TY20", schema);
            HasKey(x => x.Ty20001);

            Property(x => x.Ty20001).HasColumnName(@"TY20001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ty20010).HasColumnName(@"TY20010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ty20100).HasColumnName(@"TY20100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ty20050).HasColumnName(@"TY20050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
        }
    }

}
