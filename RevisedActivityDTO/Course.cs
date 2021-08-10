using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedActivityDTO
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseOwner { get; set; }
        public string CourseTitle { get; set; }
        public int AssessmentId { get; set; }
        public int HoursAssigned { get; set; }
        public string CourseSyllabus { get; set; }
    }
}
