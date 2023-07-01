using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities;
public class Department
{
      [Key]
    public int DepatrmentId { get; set; }
    
    [Required, MaxLength(50)]
    public string Name { get; set; }
    // Тугри аст Акай Нуруллох???
    public  required List<DepartmentEmployee> GetDepartmentEmployees { get; set; }
    public  required List<DepartmentManager> DepartmentManagers { get; set; }
}