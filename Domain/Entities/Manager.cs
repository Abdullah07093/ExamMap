using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities;
public class Manager
{
    public int ManagerId { get; set; }
    public int FullName { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}