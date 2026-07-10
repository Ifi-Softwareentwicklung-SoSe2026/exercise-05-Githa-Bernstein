
class Program
{
    static void Main(string[]? args)
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


    static void command_line_handler(string[]? args, TournamentData tournamentData)
    {
        var persistence_manager = new PersistenceManager();
        
        if(args.Length > 0)
        {
            if(args.Contains("new")){
                var spiel_1 = new Spiel{ID = "Spiel 1 wurde erstellt"};
                var manschaft_1 = new Mannschaft{Name = "Mannschaft 1 wurde erstellt"};

                tournamentData.spiele.Add(spiel_1);
                tournamentData.mannschaften.Add(manschaft_1); 

           

                persistence_manager.saveTournament(tournamentData);
            }
        

            if(args.Contains("print"))
            {
            
                try{
            
               
                    tournamentData = persistence_manager.loadTournament();
                
                    Console.WriteLine(tournamentData.spiele[0]);


                }
                catch
                {
                    Console.WriteLine("Nicht möglich");
                }

            }

        }
        else
        {
            var spiel_1 = new Spiel{ID = "Spiel 1 wurde erstellt"};
            var manschaft_1 = new Mannschaft{Name = "Mannschaft 1 wurde erstellt"};

            tournamentData.spiele.Add(spiel_1);
            
            tournamentData.mannschaften.Add(manschaft_1); 


            persistence_manager.saveTournament(tournamentData);

            try{
            
               
                tournamentData = persistence_manager.loadTournament();
                
                Console.WriteLine(tournamentData.spiele[0]);


            }
            catch
            {
                Console.WriteLine("Nicht möglich");
            }
            
        }
      
        
    }

   
}

