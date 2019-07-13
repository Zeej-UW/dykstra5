using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        // Similar to varchar(50) in SQL—forces a character limit on the names being entered.
        // Allows them to enter whitespace if wanted. RegularExpression will force the user to abide by certain input.
        // Also forces that a value be entered and changes the display name of the column within the table.
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        // Makes it so our date string is formatted in a particular way.
        // Forces the date to abide by year/month/day vs. year/month/day/time.
        // 2nd param forces the edit box to abide by this rule and display it when viewed.
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        // Creates a full name from the other two columns.
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}