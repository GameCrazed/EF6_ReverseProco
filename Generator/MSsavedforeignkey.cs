

namespace Generator
{

    public class MSsavedforeignkey
    {
        public string ProgramName { get; set; }
        public string ConstraintName { get; set; }
        public string ParentSchema { get; set; }
        public string ParentName { get; set; }
        public string ReferencedObjectSchema { get; set; }
        public string ReferencedObjectName { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsNotForReplication { get; set; }
        public bool IsNotTrusted { get; set; }
        public byte DeleteReferentialAction { get; set; }
        public byte UpdateReferentialAction { get; set; }
        public System.DateTime Timestamp { get; set; }
    }

}
