﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace student.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string student_Name { get; set; }
        public string student_Email { get; set; }
        public string student_Mobile { get; set; }
        public string course_Name { get; set; }
        public string course_Duration { get; set; }
    }
}
