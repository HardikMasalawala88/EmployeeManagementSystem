using Data.FormModels;
using System.ComponentModel.DataAnnotations;

namespace EMS.Data.FormModels.EmpSalary
{
    public class CreateAmountVM
    {
        public EmployeeVM? RequestingEmployee { get; set; }
        [Display(Name = "Employee Name")]
        public string? RequestingEmployeeId { get; set; }

        [Required]
        [Display(Name = "SalaryAmount ")]
        public double SalaryAmount { get; set; }
        public EmployeeVM? EmployeeVM { get; set; }
    }
}
