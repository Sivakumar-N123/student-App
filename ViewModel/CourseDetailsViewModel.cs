using System.ComponentModel.DataAnnotations;

namespace studentApp.ViewModel
{
    public class CourseDetailsViewModel
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
       
        
    }
}
