using System;
using System.Collections.Generic;

// Step 3: Create the data model
namespace lab11_solution.Models
{
    public class Professor
    {
        public int ProfessorId {get; set;} // Primary Key
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public List<Course> Courses {get; set;}
    }
}