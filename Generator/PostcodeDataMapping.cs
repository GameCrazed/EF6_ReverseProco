

namespace Generator
{

    public class PostcodeDataMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PostcodeData>
    {
        public PostcodeDataMapping()
            : this("dbo")
        {
        }

        public PostcodeDataMapping(string schema)
        {
            ToTable("postcodeData", schema);
            HasKey(x => new { x.Id, x.PartialPostcode, x.X, x.Y, x.Latitude, x.Longitude, x.Town, x.County, x.Region });

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PartialPostcode).HasColumnName(@"partialPostcode").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.X).HasColumnName(@"x").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Y).HasColumnName(@"y").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Latitude).HasColumnName(@"latitude").HasColumnType("numeric").IsRequired().HasPrecision(4,2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Longitude).HasColumnName(@"longitude").HasColumnType("numeric").IsRequired().HasPrecision(4,2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Town).HasColumnName(@"town").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(22).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.County).HasColumnName(@"county").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(24).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Region).HasColumnName(@"region").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(24).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GeoLocation).HasColumnName(@"GeoLocation").HasColumnType("geography").IsOptional();
            Property(x => x.StartPostcode).HasColumnName(@"startPostcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
        }
    }

}
