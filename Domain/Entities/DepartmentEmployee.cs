using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities;
public class DepartmentEmployee
{
    
public int EmployeeId { get; set; }

     public  Employee Employee { get; set; }

    public int DepatrmentId { get; set; }

     public  Department Depatrment { get; set; }
      
    [Required]
    public DateTime FromDate { get; set; }
    [Required]
    public DateTime ToDate { get; set; }




}