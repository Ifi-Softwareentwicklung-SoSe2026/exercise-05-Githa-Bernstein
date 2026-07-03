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

  
}


class TournamentData
{
    public TournamentData(List<Spiel> spiel_liste, List<Mannschaft> mannschafts_liste)
    {
        spiele = spiel_liste;
        mannschaften = mannschafts_liste;
    }
    public List<Spiel> spiele;
    public List<Mannschaft> mannschaften;
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