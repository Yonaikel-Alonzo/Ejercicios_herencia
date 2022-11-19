internal class Program
{
    private static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");
      
       Empleados n2  = new Empleados("Jose","Alonzo", 310,"Soltero",2019,"340");
       n2.imprimir();
       n2.Mostrar();
       Estudiantes n3 = new Estudiantes("Yonaikel","Alonzo",410,"Soltero","A40");
       n3.imprimir();
       n3.Mostrar();
       Profesores n4 = new Profesores ("Ing.Maria","Delgado ",120,"Soltera","Matematica");
       n4.imprimir();
       n4.Mostrar();
       Personal n5 = new Personal("Ing.Jose","Alonzo",411,"Soltero","Decanato");
       n5.imprimir();
       n5.Mostrar();

    }
}