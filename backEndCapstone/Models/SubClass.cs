﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backEndCapstone.Models
{
    public class SubClass
    {
        [Key]
        public int SubClassId { get; set; }

        [Required]
        [Display(Name = "Sub Class Name")]
        public string SubClassName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string SubClassDescription { get; set; }

        [Required]
        [Display(Name = "Features")]
        public string SubClassFeatures { get; set; }

    }
}
