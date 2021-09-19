using System.Collections.Generic;
using ClanArch.Application.ViewModels;

namespace ClanArch.Application.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
