using System.ComponentModel.DataAnnotations;

namespace Api_Blazor_Project.Models
{
    public class Post
    {

        public int Id { get; set; }

        [Required (ErrorMessage ="Please Enter Your Title.")]
        public string? Title { get; set; }

        [Required (ErrorMessage ="Please Enter Your Description.")]
        public string? Description { get; set; }
        public  DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
