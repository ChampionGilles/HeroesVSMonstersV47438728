namespace HeroesVSMonsters.Models
{
    public class Dragonnet : Monstre
    {
        public Dragonnet(string _name) : base(_name) 
        {
            this.Endurance = base.Endurance + 1;
        }
        public void Loot()
        {
            Des des = new Des();
            int or = des.Lance(6);
            int cuir = des.Lance(4);
            Console.WriteLine($"Le dragonnet a loot {or} Ors et {cuir} Cuirs !");
        }
    }
}
