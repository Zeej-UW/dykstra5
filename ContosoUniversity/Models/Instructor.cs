using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    /*
     * Practically the same as the Student class but for instructors instead. Only
     * added thing is a getter/setter for two new addtl. items: OfficeAssignment and CourseAssignments.
     */
    public class Instructor
    {
        public int ID { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date), Display(Name = "Hire Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        // An instructor can have multiple CourseAssignments, hence the collection
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        // An instructor can only have one office
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}