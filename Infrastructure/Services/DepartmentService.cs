using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Dtos;
using WebApi.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApi.Controllers;

    public class DepartmentService{
  
    private readonly DataContext context;

    public DepartmentService(DataContext context)
    {
        this.context = context;
    }
    public async Task< List<GetDepartmentsDto>> GetDepartments()
    {
//var query= context.Departments.AsQueryable();

       // return await context.Departments.ToListAsync();

var data= (from s in context.Departments join u in context.Managers on s.DepartmentManagers.ManagerId equals u.ManagerId  );


        return await context.Departments.Select(E=>new GetDepartmentsDto(){
             DepatrmentId=E.DepatrmentId,
             Name=E.Name,
             ManagerId=E.DepartmentManagers
             ManagerFullName=E.DepartmentManagers.ManagerFullName
        })
        
        .ToListAsync();
    }
    
    // public Author GetAuthorById(int id)
    // {
    //     return _context.Authors.Find(id);
    // }
    

    // public Author AddAuthor(Author model)
    // {
      
    //     _context.Authors.Add(model);
    //     _context.SaveChanges();
    //     return model;
    // }
    
    // public Author UpdateBook(Author author)
    // {
    //     _context.Authors.Update(author);
    //     _context.SaveChanges();
    //     return author;
    // }
    
    // public bool DeleteAuthor(int id)
    // {
    //    var author =  _context.Authors.Find(id);
    //    _context.Authors.Remove(author);
    //    var result =  _context.SaveChanges();
    //     return result == 1;
    // }
    
    
}