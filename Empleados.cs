class Empleados:Persona
{
    public int Años_incorporacion {get;set;}
    public string Numero_despacho { get;set;}
    public Empleados (string Nombre, string Apellido, int Numero_identificacion, string Estado_civil, int Años_incorporacion, string Numero_despacho):base(Nombre, Apellido, Numero_identificacion,Estado_civil)
    {
        this.Años_incorporacion = Años_incorporacion;
        this.Numero_despacho = Numero_despacho;
    }
    public void Mostrar ()
    {
        Console.WriteLine("------Empleados-----------");
        Console.WriteLine("Años de incorporacion : "+Años_incorporacion);
        Console.WriteLine("Numero de despacho : "+Numero_despacho);
        Console.WriteLine("");
        opcioness();
        Console.WriteLine("");
    }
    public void opcioness()
    {
        String options;
        Console.WriteLine("Opciones alternas:");
        Console.WriteLine("Si desea cambiar el despacho utilize Ingrese: 1");
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
            cambio_despacho();
            break;
            case "2":
            cambiocivil();
            break;
            case "salir":
            Console.WriteLine("....");
            break;
         }
    }      
    public void cambio_despacho()
    {
        String despacho_new;
        Console.WriteLine("Ingrese el nuevo despacho");
        despacho_new = Console.ReadLine();
        Console.WriteLine("despacho cambiado exitosamente");
        Numero_despacho = despacho_new;
    }
}