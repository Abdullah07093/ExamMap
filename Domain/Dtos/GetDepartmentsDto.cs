namespace WebApi.Controllers
{
    public class GetDepartmentsDto
    {
        public int DepatrmentId { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public string ManagerFullName { get; set; }


    }
}