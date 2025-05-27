namespace HeroesVSMonsters.Models
{
    public class Humain : Heros
    {
        public Humain(string _name) : base(_name)
        {
            this.Endurance = base.Endurance + 1;
        }
    }
}
