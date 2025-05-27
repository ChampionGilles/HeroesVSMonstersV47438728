namespace HeroesVSMonsters.Models
{
    public class Loup : Monstre
    {
        public Loup(string _name) : base(_name) {}

        public void Loot()
        {
            Des des = new Des();
            int cuir = des.Lance(4);
            Console.WriteLine($"Le Loup a loot {cuir} Cuirs !");
        }
    }
}
