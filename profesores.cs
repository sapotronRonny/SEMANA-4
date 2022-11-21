class profesores:persona{
    public int añoincor {get;set;}
    public int numdespacho {get;set;}
    public string departamento {get;set;}


    public profesores (int añoincor,int numdespacho,string departamento,string nom,string apell,int numIdentificacion,string estadocivil):base(nom,apell,numIdentificacion,estadocivil){
        this.añoincor = añoincor;
        this.numdespacho = numdespacho;
        this.departamento = departamento;
    }

    public void cambioDepartamento(string departamento2){
        departamento=departamento2;
        Console.WriteLine ("Su area de educacion es: "+departamento);
    }
    public void cambioDespacho(int numerodespacho2){
        numdespacho=numerodespacho2;
        Console.WriteLine ("Su numero de despacho es: "+numdespacho);
    }

}