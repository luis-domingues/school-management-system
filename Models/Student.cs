using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modelo_teste.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Dictionary<string, Course> SelectedCourses { get; set; } = new Dictionary<string, Course>();

        public void AddCourse(string courseName, Course course)
        {
            SelectedCourses.Add(courseName, course);
        }
    }
}