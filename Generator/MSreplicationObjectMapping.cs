

namespace Generator
{

    public class MSreplicationObjectMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MSreplicationObject>
    {
        public MSreplicationObjectMapping()
            : this("dbo")
        {
        }

        public MSreplicationObjectMapping(string schema)
        {
            ToTable("MSreplication_objects", schema);
            HasKey(x => new { x.ObjectName, x.ObjectType });

            Property(x => x.Publisher).HasColumnName(@"publisher").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.PublisherDb).HasColumnName(@"publisher_db").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Publication).HasColumnName(@"publication").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.ObjectName).HasColumnName(@"object_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ObjectType).HasColumnName(@"object_type").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Article).HasColumnName(@"article").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
        }
    }

}
