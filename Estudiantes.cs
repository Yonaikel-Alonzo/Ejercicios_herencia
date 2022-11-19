class Estudiantes:Persona
{
    public string  Curso_matricula {get;set;}
    public Estudiantes (string Nombre, string Apellido, int Numero_identificacion, string Estado_civil,string  Curso_matricula):base(Nombre, Apellido, Numero_identificacion,Estado_civil)
    {
        this.Curso_matricula = Curso_matricula;
    }
    public void Mostrar ()
    {        
        Console.WriteLine ("-------Estudiantes--------------");
        Console.WriteLine("Curso de matricula : "+Curso_matricula);
        Console.WriteLine("");
        opcioness();
        Console.WriteLine("");
    }
    public void opcioness()
    {
        String options;
        Console.WriteLine("Opciones alternas:");
        Console.WriteLine("Si desea cambiar el curso utilize Ingrese: 1");
        Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
        Console.WriteLine("Si desea salir utilize: salir ");
        options = Console.ReadLine();
        cambio(options);
    }
    public void cambio(String cambios)
    {
        switch (cambios.ToString())
        {
            case "1":
            curso_nuevo();
            break;
            case "2":
            cambiocivil();
            break;
            case "salir":
            Console.WriteLine("....");
            break;
        }
    }
    public void curso_nuevo()
    {
        string curso_new;
        Console.WriteLine("Ingrese el nuevo Curso");
        curso_new = Console.ReadLine();
        Console.WriteLine("Curso cambiado exitosamente");
        Curso_matricula = curso_new;
    }
}