using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewBagAndViewData.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmployeeEmail { get; set; }
    }
}
