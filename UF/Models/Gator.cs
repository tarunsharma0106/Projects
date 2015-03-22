using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UF.Models
{
    public class Gator
    {


        public int ID { get; set; }  // this is primary key for this Gator table

        public int money { get; set; }  

        public string StudentName { get; set; }
        public int UFID { get; set; }
        [Display(Name = "Enroll Date")]
        [DataType(DataType.Date)]
        public DateTime EnrollDate { get; set; }
        public string Adress { get; set; }
        public decimal GPA { get; set; }

        public int score { get; set; }
    }
}