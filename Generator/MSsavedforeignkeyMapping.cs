

namespace Generator
{

    public class MSsavedforeignkeyMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MSsavedforeignkey>
    {
        public MSsavedforeignkeyMapping()
            : this("dbo")
        {
        }

        public MSsavedforeignkeyMapping(string schema)
        {
            ToTable("MSsavedforeignkeys", schema);
            HasKey(x => new { x.ProgramName, x.ConstraintName, x.ParentSchema, x.ParentName, x.ReferencedObjectSchema, x.ReferencedObjectName, x.IsDisabled, x.IsNotForReplication, x.IsNotTrusted, x.DeleteReferentialAction, x.UpdateReferentialAction, x.Timestamp });

            Property(x => x.ProgramName).HasColumnName(@"program_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ConstraintName).HasColumnName(@"constraint_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParentSchema).HasColumnName(@"parent_schema").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ParentName).HasColumnName(@"parent_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ReferencedObjectSchema).HasColumnName(@"referenced_object_schema").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ReferencedObjectName).HasColumnName(@"referenced_object_name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsDisabled).HasColumnName(@"is_disabled").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsNotForReplication).HasColumnName(@"is_not_for_replication").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsNotTrusted).HasColumnName(@"is_not_trusted").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DeleteReferentialAction).HasColumnName(@"delete_referential_action").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UpdateReferentialAction).HasColumnName(@"update_referential_action").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Timestamp).HasColumnName(@"timestamp").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
