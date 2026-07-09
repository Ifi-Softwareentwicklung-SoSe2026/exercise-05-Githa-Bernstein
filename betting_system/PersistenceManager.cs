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

    public TournamentData? loadTournament()
    {
        
        string jsonContent = File.ReadAllText("Data.json");
        
        TournamentData? tournamentData = JsonSerializer.Deserialize<TournamentData>(jsonContent);
       
        return tournamentData;
        
    }

  
}


class TournamentData
{
    public TournamentData(List<Spiel> spiele, List<Mannschaft> mannschaften)
    {
        this.spiele = spiele;
        this.mannschaften = mannschaften;
    }
    public List<Spiel> spiele{get;set;}
    public List<Mannschaft> mannschaften{get;set;}
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