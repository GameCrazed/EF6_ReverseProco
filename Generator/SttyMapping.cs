

namespace Generator
{

    public class SttyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Stty>
    {
        public SttyMapping()
            : this("dbo")
        {
        }

        public SttyMapping(string schema)
        {
            ToTable("STTY", schema);
            HasKey(x => x.Stty010);

            Property(x => x.Stty010).HasColumnName(@"STTY010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Stty030).HasColumnName(@"STTY030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Stty040).HasColumnName(@"STTY040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Stty060).HasColumnName(@"STTY060").HasColumnType("datetime").IsRequired();
            Property(x => x.Stty070).HasColumnName(@"STTY070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Stty080).HasColumnName(@"STTY080").HasColumnType("datetime").IsRequired();
            Property(x => x.Stty110).HasColumnName(@"STTY110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Stty120).HasColumnName(@"STTY120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Stty130).HasColumnName(@"STTY130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Stty140).HasColumnName(@"STTY140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Stty210).HasColumnName(@"STTY210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Stty220).HasColumnName(@"STTY220").HasColumnType("tinyint").IsRequired();
            Property(x => x.Stty2301).HasColumnName(@"STTY2301").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Stty2302).HasColumnName(@"STTY2302").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Stty2303).HasColumnName(@"STTY2303").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Stty2401).HasColumnName(@"STTY2401").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Stty2402).HasColumnName(@"STTY2402").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Stty300).HasColumnName(@"STTY300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Sttydtm).HasColumnName(@"STTYDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Stty500).HasColumnName(@"STTY500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Stty071).HasColumnName(@"STTY071").HasColumnType("int").IsRequired();
            Property(x => x.Stty072).HasColumnName(@"STTY072").HasColumnType("datetime").IsRequired();
        }
    }

}
