
class Program
{
    static void Main(string[]? args)
    {
        TournamentData tournament_data = TournamentData_Initialisierer();
        var persistence_manager = new PersistenceManager();
        Command_line_handler(args,tournament_data, persistence_manager);
    
        
    }
    static TournamentData Beispiel_Generator(TournamentData tournamentData)
    {
        //Erstellung Mannschaften
        var mannschaft_1 = new Mannschaft{Name = "Bayern"};
        var mannschaft_2 = new Mannschaft{Name = "Baden Württemberg"};
        var mannschaft_3 = new Mannschaft{Name = "Nordrhein Westfalen"};
        var mannschaft_4 = new Mannschaft{Name = "Niedersachsen"};

        var spiel_1 = new Spiel{
            ID = "Bayern vs. BaWü", 
            HomeTeam = mannschaft_1,
            AwayTeam = mannschaft_2};

        var gruppe_1 = new Gruppe{Name = "Bundesländer", Teams = new List<Mannschaft> ()};
        gruppe_1.addTeam(mannschaft_1);
        gruppe_1.addTeam(mannschaft_2);
        gruppe_1.addTeam(mannschaft_3);
        gruppe_1.addTeam(mannschaft_4);

        tournamentData.Mannschaften.Add(mannschaft_1);
        tournamentData.Mannschaften.Add(mannschaft_2);
        tournamentData.Spiele.Add(spiel_1);
        tournamentData.Gruppen.Add(gruppe_1);

        return tournamentData;


    }

    static TournamentData TournamentData_Initialisierer()
    {
        var spiele = new List<Spiel>();
        var mannschaften = new List<Mannschaft>();
        var gruppen = new List<Gruppe>();

        var tournament_data = new TournamentData{
            Spiele = spiele,
            Mannschaften = mannschaften, 
            Gruppen = gruppen
        };

        return tournament_data;


    }


    static void Command_line_handler(string[]? args, TournamentData tournamentData, PersistenceManager persistence_manager)
    {
        
        
        
        if(args?.Length > 0)
        {
            
            
            if(args.Contains("new")){
                TournamentData tournament_Data = Beispiel_Generator(tournamentData);
                persistence_manager.saveTournament(tournament_Data);
            }
        
            if(args.Contains("print"))
            {      
                tournamentData = persistence_manager.loadTournament();

                uint counter = 0;
                foreach(Spiel spiel in tournamentData.Spiele)
                {
                    Console.WriteLine($"Spiel{counter + 1}: {spiel.HomeTeam.Name} vs. {tournamentData?.Spiele[0].AwayTeam.Name}");
                }
            }

        }
        else
        {
            TournamentData tournament_Data = Beispiel_Generator(tournamentData);
            persistence_manager.saveTournament(tournament_Data);
            
            tournamentData = persistence_manager.loadTournament();

            uint counter = 0;
            foreach(Spiel spiel in tournamentData.Spiele)
            {
                Console.WriteLine($"Spiel{counter + 1}: {spiel.HomeTeam.Name} vs. {tournamentData?.Spiele[0].AwayTeam.Name}");
            }
            
            
        }
      
        
    }

   
}

