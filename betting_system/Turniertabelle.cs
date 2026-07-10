using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Spiel {

    
    public required string ID{get;set;}
        
    public required Mannschaft HomeTeam{get;set;}
    public required Mannschaft AwayTeam{get;set;}
    public DateTime DateTime{get;set;}
    
    
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