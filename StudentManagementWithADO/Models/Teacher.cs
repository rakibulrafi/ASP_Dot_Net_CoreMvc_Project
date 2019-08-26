﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementWithADO.Models
{
    public class Teacher
    {
       
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
       
        public string Skills { get; set; }

        [Range(5, 50)]
        public int TotalStudents { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public DateTime AddedOn { get; set; }
    }
}
