

namespace Generator
{

    public class EaNote
    {
        public int NoteId { get; set; }
        public int FkApplicationId { get; set; }
        public string FkNoteRef { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string Note { get; set; }
    }

}
