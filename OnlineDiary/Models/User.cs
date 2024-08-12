using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineDiary.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string Password { get; set; }

        public List<Diary> Diaries { get; set; }
    }
}
