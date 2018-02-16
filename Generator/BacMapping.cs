

namespace Generator
{

    public class BacMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Bac>
    {
        public BacMapping()
            : this("dbo")
        {
        }

        public BacMapping(string schema)
        {
            ToTable("BACS", schema);
            HasKey(x => x.Bacs999);

            Property(x => x.Bacs001).HasColumnName(@"BACS001").HasColumnType("int").IsRequired();
            Property(x => x.Bacs010).HasColumnName(@"BACS010").HasColumnType("int").IsRequired();
            Property(x => x.Bacs020).HasColumnName(@"BACS020").HasColumnType("int").IsRequired();
            Property(x => x.Bacs300).HasColumnName(@"BACS300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bacs310).HasColumnName(@"BACS310").HasColumnType("datetime").IsRequired();
            Property(x => x.Bacs315).HasColumnName(@"BACS315").HasColumnType("datetime").IsRequired();
            Property(x => x.Bacs320).HasColumnName(@"BACS320").HasColumnType("datetime").IsRequired();
            Property(x => x.Bacs330).HasColumnName(@"BACS330").HasColumnType("smallint").IsRequired();
            Property(x => x.Bacs335).HasColumnName(@"BACS335").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Bacs337).HasColumnName(@"BACS337").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Bacs350).HasColumnName(@"BACS350").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Bacs740).HasColumnName(@"BACS740").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Bacs750).HasColumnName(@"BACS750").HasColumnType("tinyint").IsRequired();
            Property(x => x.Bacs760).HasColumnName(@"BACS760").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bacs800).HasColumnName(@"BACS800").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Bacs999).HasColumnName(@"BACS999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
