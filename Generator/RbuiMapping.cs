

namespace Generator
{

    public class RbuiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rbui>
    {
        public RbuiMapping()
            : this("dbo")
        {
        }

        public RbuiMapping(string schema)
        {
            ToTable("RBUI", schema);
            HasKey(x => new { x.Rbui001, x.Rbui020 });

            Property(x => x.Rbui001).HasColumnName(@"RBUI001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rbui020).HasColumnName(@"RBUI020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rbui030).HasColumnName(@"RBUI030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Rbui040).HasColumnName(@"RBUI040").HasColumnType("datetime").IsRequired();
            Property(x => x.Rbui050).HasColumnName(@"RBUI050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Rbui060).HasColumnName(@"RBUI060").HasColumnType("datetime").IsRequired();
            Property(x => x.Rbui070).HasColumnName(@"RBUI070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Rbui080).HasColumnName(@"RBUI080").HasColumnType("money").IsRequired().HasPrecision(19,4);
        }
    }

}
