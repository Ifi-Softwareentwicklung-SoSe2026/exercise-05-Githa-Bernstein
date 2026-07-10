using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;
class PersistenceManager
{
    public void saveTournament(TournamentData data)
    {
      
        var jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText("Data.json", jsonString);
        

    }

    public TournamentData loadTournament()
    {
        
        string jsonContent = File.ReadAllText("Data.json");
        
        var data = JsonSerializer.Deserialize<TournamentData>(jsonContent);
        return  data ?? new TournamentData{Spiele = new(), Mannschaften = new(), Gruppen = new()};  
    }

  
}


class TournamentData
{
    
    public required List<Spiel> Spiele{get;set;}
    public required List<Mannschaft> Mannschaften{get;set;}

    public required List<Gruppe> Gruppen{get;set;}

    public override string ToString()
    {
        return $"{Spiele}";
    }
}



   /*Kommt in SaveTo
   public void saveBets( List<Wette> bets)
    {
        var JsonString2 = JsonSerializer.Serialize(bets);
         File.WriteAllText("Data.json", JsonString2);
        
    }
    public List<Wette> loadBets()
    {
       return; 
    }
   */