using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Spiel {

    
    public required string ID{get;set;}
        
    public Mannschaft? homeTeam{get;set;}
    public Mannschaft? awayTeam{get;set;}
    public DateTime? dateTime{get;set;}
    public string? result{get;set;}
    
}

class Mannschaft {

    public required string Name{get;set;}
}

class Gruppe {
    public required string Name{get;set;}
    public required List<Mannschaft> Teams{get;set;}

    public void addTeam(Mannschaft team)
    {
        Teams.Add(team);
    }
  
    
}