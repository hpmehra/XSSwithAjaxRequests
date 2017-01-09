using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XSS_with_Ajax_Requests.Models
{
    public class Employee
    {
        
        public int ID { get; set; }

        
        public string Name { get; set; }

       
        public float Salary { get; set; }
    }
}