﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    // Department class that handles instructor departments and their properties.
    public class Department
    {
        // Key to keep track of our departments
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        // Changes the data type mapping to 'money' rather than what it was previously.
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        // foreign key that can be nullable (i.e. we may or may not have an instructor)
        public int? InstructorID { get; set; }

        // An admin is always an instructor
        public Instructor Administrator { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}