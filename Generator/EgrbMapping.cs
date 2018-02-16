

namespace Generator
{

    public class EgrbMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Egrb>
    {
        public EgrbMapping()
            : this("dbo")
        {
        }

        public EgrbMapping(string schema)
        {
            ToTable("EGRB", schema);
            HasKey(x => x.Egrb010);

            Property(x => x.Egrb010).HasColumnName(@"EGRB010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Egrb030).HasColumnName(@"EGRB030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Egrb050).HasColumnName(@"EGRB050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Egrb060).HasColumnName(@"EGRB060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Egrb080).HasColumnName(@"EGRB080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Egrb090).HasColumnName(@"EGRB090").HasColumnType("datetime").IsRequired();
            Property(x => x.Egrb100).HasColumnName(@"EGRB100").HasColumnType("int").IsRequired();
            Property(x => x.Egrb105).HasColumnName(@"EGRB105").HasColumnType("datetime").IsRequired();
            Property(x => x.Egrb110).HasColumnName(@"EGRB110").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrb130).HasColumnName(@"EGRB130").HasColumnType("datetime").IsRequired();
            Property(x => x.Egrb156).HasColumnName(@"EGRB156").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Egrb160).HasColumnName(@"EGRB160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrb170).HasColumnName(@"EGRB170").HasColumnType("datetime").IsRequired();
            Property(x => x.Egrb180).HasColumnName(@"EGRB180").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrb182).HasColumnName(@"EGRB182").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrb184).HasColumnName(@"EGRB184").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrb186).HasColumnName(@"EGRB186").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrb200).HasColumnName(@"EGRB200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrb210).HasColumnName(@"EGRB210").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Egrbdtm).HasColumnName(@"EGRBDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Egrb220).HasColumnName(@"EGRB220").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Egrb230).HasColumnName(@"EGRB230").HasColumnType("datetime").IsRequired();
        }
    }

}
