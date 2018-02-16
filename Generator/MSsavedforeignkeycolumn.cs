

namespace Generator
{

    public class MSsavedforeignkeycolumn
    {
        public string ProgramName { get; set; }
        public string ConstraintName { get; set; }
        public string ParentSchema { get; set; }
        public int ConstraintColumnId { get; set; }
        public string ReferencingColumnName { get; set; }
        public string ReferencedColumnName { get; set; }
        public System.DateTime Timestamp { get; set; }
    }

}
