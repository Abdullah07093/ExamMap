using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities;
public class DepartmentManager
{

    public int EmployeeId { get; set; }

     public  Employee Employee { get; set; }

    public int ManagerId { get; set; }

     public  Manager Manager { get; set; }
      
    [Required]
    public DateTime FromDate { get; set; }
    [Required]
    public DateTime ToDate { get; set; }
}