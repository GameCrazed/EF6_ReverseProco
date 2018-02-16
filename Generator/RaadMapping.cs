

namespace Generator
{

    public class RaadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Raad>
    {
        public RaadMapping()
            : this("dbo")
        {
        }

        public RaadMapping(string schema)
        {
            ToTable("RAAD", schema);
            HasKey(x => x.Raad001);

            Property(x => x.Raad001).HasColumnName(@"RAAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Raad010).HasColumnName(@"RAAD010").HasColumnType("datetime").IsRequired();
            Property(x => x.Raad020).HasColumnName(@"RAAD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Raad046).HasColumnName(@"RAAD046").HasColumnType("int").IsRequired();
            Property(x => x.Raad104).HasColumnName(@"RAAD104").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Raad105).HasColumnName(@"RAAD105").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Raad170).HasColumnName(@"RAAD170").HasColumnType("datetime").IsRequired();
            Property(x => x.Raad180).HasColumnName(@"RAAD180").HasColumnType("int").IsRequired();
            Property(x => x.Raad418).HasColumnName(@"RAAD418").HasColumnType("int").IsRequired();
            Property(x => x.Raad420).HasColumnName(@"RAAD420").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Raad422).HasColumnName(@"RAAD422").HasColumnType("int").IsRequired();
            Property(x => x.Raad424).HasColumnName(@"RAAD424").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Raad428).HasColumnName(@"RAAD428").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Raad200).HasColumnName(@"RAAD200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Raad300).HasColumnName(@"RAAD300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Raad310).HasColumnName(@"RAAD310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Raad315).HasColumnName(@"RAAD315").HasColumnType("tinyint").IsRequired();
            Property(x => x.Raad450).HasColumnName(@"RAAD450").HasColumnType("int").IsRequired();
            Property(x => x.Raad455).HasColumnName(@"RAAD455").HasColumnType("int").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Raaddtm).HasColumnName(@"RAADDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Raad350).HasColumnName(@"RAAD350").HasColumnType("tinyint").IsRequired();
            Property(x => x.Raad360).HasColumnName(@"RAAD360").HasColumnType("tinyint").IsRequired();
            Property(x => x.Raad150).HasColumnName(@"RAAD150").HasColumnType("int").IsRequired();
            Property(x => x.Raad301).HasColumnName(@"RAAD301").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Raad460).HasColumnName(@"RAAD460").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Raad470).HasColumnName(@"RAAD470").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Raad670).HasColumnName(@"RAAD670").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Raad500).HasColumnName(@"RAAD500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Raad370).HasColumnName(@"RAAD370").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Raad380).HasColumnName(@"RAAD380").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Raad050).HasColumnName(@"RAAD050").HasColumnType("datetime").IsRequired();
        }
    }

}
