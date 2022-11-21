class persona{
    private string nom{get;set;}
    private string apell{get;set;}
    private int numIdentificacion{get;set;}
    private string estadocivil{get;set;}

    public persona (string nom,string apell,int numIdentificacion,string estadocivil){
        this.nom = nom;
        this.apell = apell;
        this.numIdentificacion = numIdentificacion;
        this.estadocivil = estadocivil;
    }

    public void cambiarEstadoCivil(string estadocivil2){
        Console.WriteLine ("En primera instancia, su estado civil es: "+estadocivil);
        estadocivil=estadocivil2;
    }
    public void Imprimir(){
        Console.WriteLine("Nombre: "+nom);
        Console.WriteLine("Apellido: "+apell);
        Console.WriteLine("ID: "+numIdentificacion);
        Console.WriteLine("Estado Civil cambiado: "+estadocivil);
        
    }
}