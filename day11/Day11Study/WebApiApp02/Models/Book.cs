using System.ComponentModel.DataAnnotations;

namespace WebApiApp02.Models
{
    public class Book
    {
        // Key
        [Key]
        public int Id { get; set; }

        // 책제목
        [Required]
        public string Names { get; set; }

        // 책저자
        [Required]
        public string Author { get; set; }

        // 출판일
        [Required]
        public DateOnly ReleseDate { get; set; }


    }
}
