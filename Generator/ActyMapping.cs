

namespace Generator
{

    public class ActyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Acty>
    {
        public ActyMapping()
            : this("dbo")
        {
        }

        public ActyMapping(string schema)
        {
            ToTable("ACTY", schema);
            HasKey(x => x.Acty010);

            Property(x => x.Acty010).HasColumnName(@"ACTY010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Acty030).HasColumnName(@"ACTY030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(9);
            Property(x => x.Acty070).HasColumnName(@"ACTY070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty080).HasColumnName(@"ACTY080").HasColumnType("datetime").IsRequired();
            Property(x => x.Acty090).HasColumnName(@"ACTY090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acty100).HasColumnName(@"ACTY100").HasColumnType("datetime").IsRequired();
            Property(x => x.Acty140).HasColumnName(@"ACTY140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty2911).HasColumnName(@"ACTY2911").HasColumnType("int").IsRequired();
            Property(x => x.Acty2912).HasColumnName(@"ACTY2912").HasColumnType("int").IsRequired();
            Property(x => x.Acty2913).HasColumnName(@"ACTY2913").HasColumnType("int").IsRequired();
            Property(x => x.Acty2914).HasColumnName(@"ACTY2914").HasColumnType("int").IsRequired();
            Property(x => x.Acty2915).HasColumnName(@"ACTY2915").HasColumnType("int").IsRequired();
            Property(x => x.Acty2916).HasColumnName(@"ACTY2916").HasColumnType("int").IsRequired();
            Property(x => x.Acty2917).HasColumnName(@"ACTY2917").HasColumnType("int").IsRequired();
            Property(x => x.Acty2918).HasColumnName(@"ACTY2918").HasColumnType("int").IsRequired();
            Property(x => x.Acty2919).HasColumnName(@"ACTY2919").HasColumnType("int").IsRequired();
            Property(x => x.Acty29110).HasColumnName(@"ACTY29110").HasColumnType("int").IsRequired();
            Property(x => x.Acty29111).HasColumnName(@"ACTY29111").HasColumnType("int").IsRequired();
            Property(x => x.Acty29112).HasColumnName(@"ACTY29112").HasColumnType("int").IsRequired();
            Property(x => x.Acty300).HasColumnName(@"ACTY300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Acty310).HasColumnName(@"ACTY310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty320).HasColumnName(@"ACTY320").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acty330).HasColumnName(@"ACTY330").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acty340).HasColumnName(@"ACTY340").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Acty350).HasColumnName(@"ACTY350").HasColumnType("tinyint").IsRequired();
            Property(x => x.Acty410).HasColumnName(@"ACTY410").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty420).HasColumnName(@"ACTY420").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Acty430).HasColumnName(@"ACTY430").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty440).HasColumnName(@"ACTY440").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Acty501).HasColumnName(@"ACTY501").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty502).HasColumnName(@"ACTY502").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty503).HasColumnName(@"ACTY503").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty505).HasColumnName(@"ACTY505").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty506).HasColumnName(@"ACTY506").HasColumnType("smallint").IsRequired();
            Property(x => x.Acty507).HasColumnName(@"ACTY507").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty508).HasColumnName(@"ACTY508").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty509).HasColumnName(@"ACTY509").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty510).HasColumnName(@"ACTY510").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty511).HasColumnName(@"ACTY511").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty512).HasColumnName(@"ACTY512").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty513).HasColumnName(@"ACTY513").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty514).HasColumnName(@"ACTY514").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty515).HasColumnName(@"ACTY515").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty516).HasColumnName(@"ACTY516").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty517).HasColumnName(@"ACTY517").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty518).HasColumnName(@"ACTY518").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty519).HasColumnName(@"ACTY519").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty520).HasColumnName(@"ACTY520").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Acty530).HasColumnName(@"ACTY530").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Acty040).HasColumnName(@"ACTY040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(34);
            Property(x => x.Actydtm).HasColumnName(@"ACTYDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Acty045).HasColumnName(@"ACTY045").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Acty600).HasColumnName(@"ACTY600").HasColumnType("int").IsRequired();
            Property(x => x.Acty305).HasColumnName(@"ACTY305").HasColumnType("int").IsRequired();
            Property(x => x.Acty110).HasColumnName(@"ACTY110").HasColumnType("int").IsRequired();
            Property(x => x.Acty360).HasColumnName(@"ACTY360").HasColumnType("int").IsRequired();
            Property(x => x.Acty370).HasColumnName(@"ACTY370").HasColumnType("datetime").IsRequired();
            Property(x => x.Acty062).HasColumnName(@"ACTY062").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
