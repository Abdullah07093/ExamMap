using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController:ControllerBase
{
    public readonly DepartmentService service;
public DepartmentController(DepartmentService service)
{
    this.service=service;
}
[HttpGet("GetDepartments")]
    public async Task< List<GetDepartmentsDto>> Getepartments()
    {
        return  await service.GetDepartments();
    }




}