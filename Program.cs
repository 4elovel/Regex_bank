using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string patern = @"^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[*#+@])(?!.*\s).{4,6}$";
        Regex rg = new Regex(patern);
        Console.WriteLine("Write your passwords:\n"); // Acd@1,a B1#,2w3E*,2We#3345
        string [] str = Console.ReadLine().Split(",");
        Console.WriteLine("Right passwords:\n");
        foreach (string i in str)
        {
            if(rg.IsMatch(i) && i.Length>=4 && i.Length<=6)
            {
                Console.Write(i);
                Console.Write(',');
            }
        }
        Console.Write("\b");
    }
}