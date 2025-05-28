namespace HeroesVSMonsters.Models
{
    public class Orque : Monstre
    {
        public Orque(string _name) : base(_name)
        {
            this.Force = base.Force +1;
        }
    }
}
