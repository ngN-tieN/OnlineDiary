using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineDiary.Models
{
    [Table("diaries")]
    public class Diary
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Posted { get; set; }
    }
}
}
