using System.ComponentModel.DataAnnotations;

namespace studentApp.ViewModel
{
    public class CourseDetails
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

    }
}
