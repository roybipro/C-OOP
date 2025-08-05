using AnimeStreaming;

class Program
{
    static void Main(string[] args)
    {
      PositiveCharacter positiveCharacter = new PositiveCharacter("PC001", "Naruto Uzumaki", "Naruto", 9001, "Yes", 220);
        PositiveCharacter negativeCharacter = new PositiveCharacter(    "NC001", "Sasuke Uchiha", "Naruto", 8000, "No", 220);
        Villain villain = new Villain("V001", "Orochimaru", "Naruto", 100, "Defeated");
        positiveCharacter.ShowInfo();
        Console.WriteLine();
        negativeCharacter.ShowInfo();
        Console.WriteLine();
        villain.ShowInfo();
        Console.WriteLine();
        Console.WriteLine("Popularity Check for Positive Character: " + (positiveCharacter.CheckPopularity() ? "Popular" : "Not Popular"));
        Console.WriteLine();
        Console.WriteLine("Popularity Check for Negative Character: " + (negativeCharacter.CheckPopularity() ? "Popular" : "Not Popular"));
        
    }
}
