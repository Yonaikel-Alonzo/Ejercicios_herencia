class Profesores:Persona
{
    public string Departamento{get;set;}
    public Profesores (string Nombre, string Apellido, int Numero_identificacion, string Estado_civil, string Departamento ):base(Nombre, Apellido, Numero_identificacion,Estado_civil)
    {
        this.Departamento = Departamento;
    }
     public void Mostrar ()
    { 
    Console.WriteLine ("-------Profesor--------------");
    Console.WriteLine(" Departamento : "+Departamento);
    Console.WriteLine("");
    opcioness();
    Console.WriteLine("");
    }
    public void opcioness()
    {
        String options;
        Console.WriteLine("Opciones alternas:");
        Console.WriteLine("Si desea cambiar el personal utilize Ingrese: 1");
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
            cambio_de_departamento();
            break;
            case "2":
            cambiocivil();
            break;
            case "salir":
            Console.WriteLine("....");
            break;
        }
    }
    public void cambio_de_departamento()
    {
        String departmento_nuevo;
        Console.WriteLine("Ingrese el nuevo departamento");
        departmento_nuevo = Console.ReadLine();
        Console.WriteLine("Departamento cambiado exitosamente");
        departmento_nuevo = departmento_nuevo;
    }
}