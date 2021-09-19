using System;
using System.Collections.Generic;
using System.Text;
using ClanArch.Application.Interfaces;
using ClanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;

namespace ClanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
