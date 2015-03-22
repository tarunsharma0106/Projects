using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UF.Models
{
    public class Test
    {
        public int ID { get; set; }
        public int MONEY { get; set; }
        public int score { get; set; }
        [Display(Name = "Question  1")]
        public string Question1 { get; set; }

        [Display(Name = "Question  2")]
        public string Question2 { get; set; }

        [Display(Name = "Question  3")]
        public string Question3 { get; set; }

        [Display(Name = "Question  4")]
        public string Question4 { get; set; }

        [Display(Name = "Question  5")]
        public string Question5 { get; set; }

        [Display(Name = "Question  6")]
        public string Question6 { get; set; }


        public int UFID { get; set; }
        public virtual Gator Gator { get; set; }
        
    }
}