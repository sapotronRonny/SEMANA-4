class estudiantes:persona{
    public string cursomatriculado {get;set;}

    public estudiantes (string nom,string apell,int numIdentificacion,string estadocivil,string cursomatriculado):base(nom,apell,numIdentificacion,estadocivil){
        this.cursomatriculado = cursomatriculado;
    }

    public void cambiarmatricula(string curso2){
        cursomatriculado=curso2;
        Console.WriteLine ("Su semestre matriculado es: "+cursomatriculado);
    }
}