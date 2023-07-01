using WebApi.Context;
using WebApi.Dtos;
using WebApi.Entities;
public class EditorService
{
    
    private readonly DataContext _context;
 
    public EditorService(DataContext context)
    {
        _context=context;
    }

//  public List<EditorBaseDto> GetEditors()
//     {
//         return _context.Editors.Select(E=>new EditorBaseDto(){

//         })
        
//         .ToList();
//     }
   
//     public EditorBaseDto GetEditorsById(int id)
//     {
//          var editor=_context.Editors.Find(id);

//          return new EditorBaseDto(){
//           Id=editor.Id,
//             Ssn=editor.Ssn,
//             Firstname=editor.Firstname,
//             Lastname=editor.Lastname,
//             Phone=editor.Phone,
//             EditorPosition=editor.EditorPosition,
//             Salary=editor.Salary         };
//     }
//     public EditorBaseDto AddEditor(EditorBaseDto model){
//         var editor= new Editor(){
//             Id=model.Id,
//             Ssn=model.Ssn,
//             Firstname=model.Firstname,
//             Lastname=model.Lastname,
//             Phone=model.Phone,
//             EditorPosition=model.EditorPosition,
//             Salary=model.Salary

//         };
//             _context.Editors.Add(editor);
//             _context.SaveChanges();
//             return model;
//     }
//     public EditorBaseDto UpdateEditor(EditorBaseDto model){
//  var editor= new Editor(){
//             Id=model.Id,
//             Ssn=model.Ssn,
//             Firstname=model.Firstname,
//             Lastname=model.Lastname,
//             Phone=model.Phone,
//             EditorPosition=model.EditorPosition,
//             Salary=model.Salary

//         };       
//          _context.Editors.Update(editor);

//         _context.SaveChanges();
//         return model;

//     }
//  public bool DeleteEditor(int id){
//        var find= _context.Editors.Find(id);

//     _context.Editors.Remove(find);
//     var result= _context.SaveChanges();

//     return result==1;
//  }



}