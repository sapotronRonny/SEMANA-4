class personaldel:persona{

    public int añoincor {get;set;}
    public int numdespacho {get;set;}
    public string asignacion {get;set;}


    public personaldel (int añoincor,int numdespacho,string asignacion,string nom,string apell,int numIdentificacion,string estadocivil):base(nom,apell,numIdentificacion,estadocivil){
        this.añoincor = añoincor;
        this.asignacion = asignacion;
    }

     public void cambioseccion(string asignacion2){
        asignacion=asignacion2;
        Console.WriteLine ("Su area asignada es: "+asignacion);
    }
    public void cambiodespacho(int numdespacho2){
        numdespacho=numdespacho2;
        Console.WriteLine ("Su numero de despacho es: "+numdespacho);
    }

}