using WebApi.Models.Base;

namespace WebApi.Models;

public class Prestamo: Model
{

    public int? bookid {get; set;}

    public int? Clienteid {get;set;}

    public string? Devolucion {get;set;}

    public DateTime Loandate {get; set;}

    public DateTime returnDate {get;set;}

    public virtual Cliente? Cliente { get; set;} = default!;
    public virtual Book? Book { get; set;} = default!;
   
}