using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class Salary
{
     [Key]
    public int Id { get; set; }
    public int EmployeeId { get; set; }

     public  Employee Employee { get; set; }
   public decimal Emount { get; set; }
    
    [Required]
    public DateTime FromDate { get; set; }
    [Required]
    public DateTime ToDate { get; set; }
}