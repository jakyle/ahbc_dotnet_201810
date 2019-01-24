﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int StudentNumber { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

	public class StudentAndEnrollments
	{
		public Student Students { get; set; }
		public Enrollment Enrollment { get; set; }

	}
}