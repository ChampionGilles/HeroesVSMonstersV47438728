namespace HeroesVSMonsters.Models
{
    public class Nain : Heros
    {
        public Nain(string _name) : base(_name) 
        {
            this.Endurance =base.Endurance+ 2;   
        }
    }
}
