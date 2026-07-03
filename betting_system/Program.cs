
class Program
{
    static void Main(string[] args)
    {
        TournamentData tournament_data = TournamentData_Initialisierer();
        command_line_handler(args,tournament_data);
        
    }

    static TournamentData TournamentData_Initialisierer()
    {
        var spiele = new List<Spiel>();
        var mannschafte = new List<Mannschaft>();
        var tournament_data = new TournamentData(spiele, mannschafte);
        return tournament_data;


    }


    static void command_line_handler(string[] args, TournamentData tournamentData)
    {
        if(args.Length > 0 && args[0] == "new")
        {
           var spiel_1 = new Spiel("Spiel 1 wurde erstellt");
           var manschaft_1 = new Mannschaft("Mannschaft 1 wurde erstellt");

           tournamentData.spiele.Add(spiel_1);
           tournamentData.mannschaften.Add(manschaft_1); 

           var persistence_manager = new PersistenceManager();

           persistence_manager.saveTournament(tournamentData);
        }
      
        
    }

   
}

