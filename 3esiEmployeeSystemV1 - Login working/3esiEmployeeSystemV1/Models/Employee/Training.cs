﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _3esiEmployeeSystemV1.Models.Employee
{
    public class Training
    {
        public int TrainingID { get; set; }

        public int EmployeeID { get; set; }

        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        public int TrainingTypeID { get; set; }

        public int TrainingCategoryID { get; set; }

        [Display(Name = "Offered By")]
        public string OfferedBy { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        public string Feedback { get; set; }


        //------------------------------ Relationships ------------------------------//

        public virtual Employee Employee { get; set; }

        public virtual TrainingType TrainingType { get; set; }

        public virtual TrainingCategory TrainingCategory { get; set; }
    }

    public class TrainingCategory
    {
        public int ID { get; set; }

        [Display(Name = "Category")]
        public string Name { get; set; }

        public virtual List<Training> Trainings { get; set; }
    }

    public class TrainingType
    {
        public int ID { get; set; }

        [Display(Name = "Type")]
        public string Name { get; set; }

        public virtual List<Training> Trainings { get; set; }
    }
}