namespace HeroesVSMonsters.Models
{
    public class Orque : Monstre, ILootOr
    {
        public Orque(string _name) : base(_name)
        {
            this.Force = base.Force +1;
        }
        public void Loot()
        {
            Des des = new Des();
            int or =des.Lance(6);
            Console.WriteLine($"L'Orque a drop {or} Ors !");           
        }
    }
}
