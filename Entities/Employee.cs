﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        public string LastName { get; set; }

        public int? Age { get; set; }
        public string? Position { get; set; }

        [ForeignKey(nameof(Project))]
        public Guid? ProjectId { get; set; }  /* FK */
        public Project Project { get; set; } /* Navigation property */
    }
}
