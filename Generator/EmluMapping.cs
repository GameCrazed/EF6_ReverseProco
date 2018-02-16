

namespace Generator
{

    public class EmluMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Emlu>
    {
        public EmluMapping()
            : this("dbo")
        {
        }

        public EmluMapping(string schema)
        {
            ToTable("EMLU", schema);
            HasKey(x => x.Emlu999);

            Property(x => x.Emlu001).HasColumnName(@"EMLU001").HasColumnType("int").IsRequired();
            Property(x => x.Emlu010).HasColumnName(@"EMLU010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(16);
            Property(x => x.Emlu020).HasColumnName(@"EMLU020").HasColumnType("smallint").IsRequired();
            Property(x => x.Emlu999).HasColumnName(@"EMLU999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
