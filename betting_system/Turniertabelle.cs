using System.Security.Cryptography.X509Certificates;

class Spiel {

    public Spiel(string name)
    {
        Console.WriteLine(name);
        Name = name;
    }
    public string Name{get;set;}
    
}

class Mannschaft {
    public Mannschaft(string name)
    {
        Console.WriteLine(name);
        Name = name;
    }
    public string Name{get;set;}
}