using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineDiary.Models
{
    [Table("diaries")]
    public class Diary
    {
        [Key]
        public string DiaryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Posted { get; set; }

        //1 diary page belong to 1 user 
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }  
    }
}

