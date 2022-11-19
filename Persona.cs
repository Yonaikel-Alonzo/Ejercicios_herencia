class Persona
{
    public string Nombre {get;set;}
    public string Apellido {get;set;}
    public int Numero_identificacion {get;set;}
    public string Estado_civil {get;set;}
    public Persona (string Nombre, string Apellido, int Numero_identificacion, string Estado_civil)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Numero_identificacion = Numero_identificacion;
        this.Estado_civil = Estado_civil;
    }
        public void imprimir ()
    {
        Console.WriteLine("");
        Console.WriteLine("..................");
        Console.WriteLine("Nombre : "+Nombre);
        Console.WriteLine("Apellido : "+ Apellido);
        Console.WriteLine("Numero de identificacion : "+Numero_identificacion);
        Console.WriteLine("Estado civil : "+Estado_civil);
    }
    public void cambiocivil()
    {
        String nuevo_civil;
        do
        { 
        Console.WriteLine("Ingrese el nuevo Estado Civil");
        Console.WriteLine("- soltero ");
        Console.WriteLine("- casado ");
        Console.WriteLine("- viudo ");
        nuevo_civil = Console.ReadLine();
        if (nuevo_civil == "soltero") 
        {
        Estado_civil = nuevo_civil;
        Console.WriteLine("Cambiado correctamente");
        }
        else if (nuevo_civil == "casado") 
            {
                Estado_civil = nuevo_civil;
                Console.WriteLine("Cambiado correctamente");
            }
            else if (nuevo_civil == "viudo") 
            {
                Estado_civil = nuevo_civil;
                Console.WriteLine("Cambiado correctamente");
            } else 
            {
                Console.WriteLine("El estado civil que ingresastes es Incorrecto");
                Console.WriteLine("Ingrese el nuevo Estado Civil");
                Console.WriteLine("- soltero ");
                Console.WriteLine("- casado ");
                Console.WriteLine("- viudo ");
                nuevo_civil = Console.ReadLine();
                Console.WriteLine("Cambiado correctamente");
            }
        } while(nuevo_civil != null && nuevo_civil == "soltero" && nuevo_civil == "casado" && nuevo_civil == "viudo");
    }
}
    

