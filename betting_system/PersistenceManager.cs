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
        {
        
        if (string.IsNullOrWhiteSpace(jsonContent))
        {
            var spiele = new List<Spiel>();
            var mannschaften = new List<Mannschaft>();
            var gruppen = new List<Gruppe>();

            var empty_tournament_data = new TournamentData{
            Spiele = spiele,
            Mannschaften = mannschaften, 
            Gruppen = gruppen};

            return empty_tournament_data;
        };
        
        
        TournamentData tournamentData = JsonSerializer.Deserialize<TournamentData>(jsonContent);
       
        return tournamentData;
        }
        
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