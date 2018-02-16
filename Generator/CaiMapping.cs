

namespace Generator
{

    public class CaiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cai>
    {
        public CaiMapping()
            : this("dbo")
        {
        }

        public CaiMapping(string schema)
        {
            ToTable("CAIS", schema);
            HasKey(x => new { x.Cais000, x.Cais001, x.Cais010 });

            Property(x => x.Cais001).HasColumnName(@"CAIS001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cais010).HasColumnName(@"CAIS010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cais020).HasColumnName(@"CAIS020").HasColumnType("int").IsRequired();
            Property(x => x.Cais100).HasColumnName(@"CAIS100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(18);
            Property(x => x.Cais103).HasColumnName(@"CAIS103").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Cais105).HasColumnName(@"CAIS105").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Cais110).HasColumnName(@"CAIS110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Cais115).HasColumnName(@"CAIS115").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Cais120).HasColumnName(@"CAIS120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Cais125).HasColumnName(@"CAIS125").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Cais130).HasColumnName(@"CAIS130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Cais135).HasColumnName(@"CAIS135").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cais140).HasColumnName(@"CAIS140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cais145).HasColumnName(@"CAIS145").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cais150).HasColumnName(@"CAIS150").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(195);
            Property(x => x.Cais155).HasColumnName(@"CAIS155").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(11);
            Property(x => x.Cais160).HasColumnName(@"CAIS160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cais165).HasColumnName(@"CAIS165").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cais170).HasColumnName(@"CAIS170").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(175);
            Property(x => x.Cais175).HasColumnName(@"CAIS175").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Cais180).HasColumnName(@"CAIS180").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Cais185).HasColumnName(@"CAIS185").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(47);
            Property(x => x.Cais190).HasColumnName(@"CAIS190").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Cais195).HasColumnName(@"CAIS195").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Cais200).HasColumnName(@"CAIS200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Cais000).HasColumnName(@"CAIS000").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cais002).HasColumnName(@"CAIS002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Cais003).HasColumnName(@"CAIS003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Cais015).HasColumnName(@"CAIS015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Cais205).HasColumnName(@"CAIS205").HasColumnType("int").IsRequired();
            Property(x => x.Cais005).HasColumnName(@"CAIS005").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
