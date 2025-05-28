namespace HeroesVSMonsters.Models
{
    public class Dragonnet : Monstre
    {
        public Dragonnet(string _name) : base(_name) 
        {
            this.Endurance = base.Endurance + 1;
        }
    }
}
