class Personal:Persona
{
    public string Area {get;set;}
    public Personal (string Nombre, string Apellido, int Numero_identificacion, string Estado_civil, string Area):base(Nombre, Apellido, Numero_identificacion,Estado_civil)
    {
        this.Area = Area;
    }
        public void Mostrar ()
    {
        Console.WriteLine ("-------Personal de servicio--------------");
        Console.WriteLine(" Area asignadas : "+Area);
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
            cambio_de_personal();
            break;
            case "2":
            cambiocivil();
            break;
            case "salir":
            Console.WriteLine("....");
            break;
            }
    }
    public void cambio_de_personal()
    {
        String translado_nuevo;
        Console.WriteLine("Ingrese el nuevo translado de seccion");
        translado_nuevo = Console.ReadLine();
        Console.WriteLine("seccion cambiado exitosamente");
        Area = translado_nuevo;
    }
}
