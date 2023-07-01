using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities;
public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
    [Required, MaxLength(50)]
    public string Gender { get; set; }

    [Required]
    public DateTime BithDate { get; set; }
    [Required]
    public DateTime HireDate { get; set; }
     public List<DepartmentEmployee> DepartmentEmployees { get; set; }
    public List<DepartmentManager> DepartmentManagers { get; set; }
    
}