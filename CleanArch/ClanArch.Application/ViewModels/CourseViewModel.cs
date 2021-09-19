using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace ClanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
