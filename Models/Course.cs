using System;

namespace lab11_solution.Models
{
    public class Course
    {
        public int CourseId {get; set;} // Primary Key
        public string Description {get; set;}
        public int ProfessorId {get; set;}
        public Professor Professor {get; set;}
    }
}