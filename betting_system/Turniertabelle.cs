using System.Security.Cryptography.X509Certificates;

class Spiel {

    public Spiel(string id)
    {
        Console.WriteLine(id);
        ID = id;
    }
    public string ID{get;set;}
        
    public Mannschaft? homeTeam{get;set;}
    public Mannschaft? awayTeam{get;set;}
    public DateTime? dateTime{get;set;}
    public string? result{get;set;}
    
}

class Mannschaft {
    public Mannschaft(string name)
    {
        Console.WriteLine(name);
        Name = name;
    }
    public string Name{get;set;}
}