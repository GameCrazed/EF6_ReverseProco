

namespace Generator
{

    public class TaskConfigGroup
    {
        public int TaskConfigGroupId { get; set; }
        public int? ParentTaskConfigId { get; set; }
        public int? ParentCaseStateId { get; set; }
        public int Depth { get; set; }

        public virtual System.Collections.Generic.ICollection<TaskConfigSource> TaskConfigSources { get; set; }


        public virtual CaseState CaseState { get; set; }

        public virtual TaskConfiguration TaskConfiguration { get; set; }

        public TaskConfigGroup()
        {
            TaskConfigSources = new System.Collections.Generic.List<TaskConfigSource>();
        }
    }

}
