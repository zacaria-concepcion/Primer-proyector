namespace Zacaria20181285.Data.Models;

public class Estudiante

{
     public int EstudianteID  {get; set;}
     public string Nombre  {get; set;}= null!;
     public string Apellidos  {get; set;}= null!;
     public DateTime FechaNacimiento   {get; set;}
     public string Matricula {get; set;}= null!;
     public int CarreraId {get; set;}
     
}



