//una variabile inizializzata con ? vuole dire che puo assumere qanche null
//per esempio int? sulLivelloDelMare;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        string? nome;
        int slm = int.Parse("1");
        Console.WriteLine("Come ti chiami?");
        nome = Console.ReadLine();
        Console.WriteLine("Ciao " + nome + " ! "); 
    }
}