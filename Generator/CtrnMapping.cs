

namespace Generator
{

    public class CtrnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ctrn>
    {
        public CtrnMapping()
            : this("dbo")
        {
        }

        public CtrnMapping(string schema)
        {
            ToTable("CTRN", schema);
            HasKey(x => x.Ctrn001);

            Property(x => x.Ctrn001).HasColumnName(@"CTRN001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Ctrn005).HasColumnName(@"CTRN005").HasColumnType("int").IsRequired();
            Property(x => x.Ctrn006).HasColumnName(@"CTRN006").HasColumnType("datetime").IsRequired();
            Property(x => x.Ctrn010).HasColumnName(@"CTRN010").HasColumnType("int").IsRequired();
            Property(x => x.Ctrn015).HasColumnName(@"CTRN015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ctrn025).HasColumnName(@"CTRN025").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn027).HasColumnName(@"CTRN027").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0501).HasColumnName(@"CTRN0501").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0502).HasColumnName(@"CTRN0502").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0503).HasColumnName(@"CTRN0503").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0504).HasColumnName(@"CTRN0504").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0505).HasColumnName(@"CTRN0505").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0506).HasColumnName(@"CTRN0506").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0507).HasColumnName(@"CTRN0507").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0508).HasColumnName(@"CTRN0508").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0509).HasColumnName(@"CTRN0509").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn05010).HasColumnName(@"CTRN05010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn05011).HasColumnName(@"CTRN05011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn05012).HasColumnName(@"CTRN05012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn05013).HasColumnName(@"CTRN05013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn05014).HasColumnName(@"CTRN05014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn05015).HasColumnName(@"CTRN05015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0701).HasColumnName(@"CTRN0701").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0702).HasColumnName(@"CTRN0702").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0703).HasColumnName(@"CTRN0703").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0704).HasColumnName(@"CTRN0704").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0705).HasColumnName(@"CTRN0705").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0706).HasColumnName(@"CTRN0706").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0707).HasColumnName(@"CTRN0707").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0708).HasColumnName(@"CTRN0708").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn0709).HasColumnName(@"CTRN0709").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn07010).HasColumnName(@"CTRN07010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn07011).HasColumnName(@"CTRN07011").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn07012).HasColumnName(@"CTRN07012").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn07013).HasColumnName(@"CTRN07013").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn07014).HasColumnName(@"CTRN07014").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn07015).HasColumnName(@"CTRN07015").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn090).HasColumnName(@"CTRN090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn095).HasColumnName(@"CTRN095").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn100).HasColumnName(@"CTRN100").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn120).HasColumnName(@"CTRN120").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn125).HasColumnName(@"CTRN125").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn200).HasColumnName(@"CTRN200").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrn300).HasColumnName(@"CTRN300").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ctrndtm).HasColumnName(@"CTRNDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
