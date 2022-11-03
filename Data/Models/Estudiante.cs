

public class Estudiante

{

  public int EstudianteID { get; set; }
  public string Nombre { get; set; } = null!;
  public string Apellidos { get; set; } = null!;
  public int FechaNacimiento { get; set; }
  public int Matricula { get; set; }
  public string Carrera { get; set; }= null!;
    




     public static Zaca Crear( int EstudianteID, string Nombre,string Apellidos,int FechaNacimiento,int Matricula, string Carrera){
        return new Cris (){
            
            EstudianteID= 0,
              Nombre=Nombre,
            Apellidos = Apellidos,
             FechaNacimiento =   FechaNacimiento,
             Matricula =  Matricula,
             Carrera =  Carrera

            };
     
     }              

     public void Update(string Nombre,string Apellidos,int FechaNacimiento,int Matricula, string Carrera)
    {
         
            Nombre=Nombre;
            Apellidos = Apellidos;
             FechaNacimiento =   FechaNacimiento;
             Matricula =  Matricula;
             Carrera =  Carrera;
        
        
        
    }

}
   
