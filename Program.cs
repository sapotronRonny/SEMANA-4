internal class Program
{
    private static void Main(string[] args)
    {
        estudiantes estudiante1=new estudiantes("William","Ramirez",56,"soltero","3C");
        profesores profesor1=new profesores(2009,5015,"lenguaje","Andres","Zambrano",96,"Casado");
        personaldel limpieza1=new personaldel(2016,0219,"cafeteria","Miguel","*agrege apellido de ejemplo*",10,"Soltero");

       estudiante1.cambiarEstadoCivil("ennoviado");
       estudiante1.cambiarmatricula("4C");
       estudiante1.Imprimir();
       Console.WriteLine ("");
       profesor1.cambiarEstadoCivil("Divorciado");
       profesor1.cambioDepartamento("Algebra");
       profesor1.cambioDespacho(50);
       profesor1.Imprimir();
       Console.WriteLine ("");
       limpieza1.cambiarEstadoCivil("Casado");
       limpieza1.cambioseccion("Decanato");
       limpieza1.cambiodespacho(630);
       limpieza1.Imprimir();
    }
}