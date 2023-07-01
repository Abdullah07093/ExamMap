using WebApi.Context;
using WebApi.Dtos;
using WebApi.Entities;
public class BookAuthorService
{
    private readonly DataContext _context;
    public BookAuthorService(DataContext context)
    {
        _context=context;
    }


    //  public bool DeleteBookAuthor (int id){
    //     var find=_context.Authors.Find(id);
    //     _context.BookAuthors.Remove(find);
    //     var  result=_context.SaveChanges();
    //     return result==1;
    //  }
}