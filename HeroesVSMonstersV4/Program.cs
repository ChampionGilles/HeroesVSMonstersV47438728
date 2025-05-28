using HeroesVSMonsters.Models;
class Program
{
    static void Main()
    {
        bool rejoue = true;
        while (rejoue)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("                            Heroes VS Monsters");
            Console.WriteLine("                                 Build V4");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                   ETES VOUS PRÊT A DETRUIRE DU MONSTRE ?");
            Console.WriteLine("                           (Press Enter to kill)");

            Music music = new Music();
            music.VictoryM();
            Console.Clear();

            GamePlay gameplay = new GamePlay();

            gameplay.JeuEntier();
            Console.Clear();
            Console.WriteLine("Rejouez une petite der' ?\n" +
                "press YES to reload the game");
            string a =Console.ReadLine().ToUpper(); 

            if (a != "YES")
            {
                rejoue = false;
            }
        }
        Console.Clear();
        Console.WriteLine("See you soon petite perruche");
    }
}

