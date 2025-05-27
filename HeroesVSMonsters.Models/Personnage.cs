using System.Runtime.InteropServices.JavaScript;

namespace HeroesVSMonsters.Models
{
    public class Personnage : Des
    {
        public string Name { get; set; }
        public int BaseEndurance { get; private set; }
        public int Endurance { get; set; }
        public int BaseForce { get; private set; }
        public int Force { get; set; }
        public int PvMax { get; private set; }
        public int Pv { get; set; }

        public int RandStat()
        {
            Des des = new Des();
            List<int> list = new List<int>() {des.Lance(6), des.Lance(6), des.Lance(6), des.Lance(6)};
            list.Sort();
            list.RemoveAt(0);
            return list.Sum();
        }
        public int BonusMalus()
        {
            int jet = RandStat();

            if (jet > 15)
            {
                jet+=2;
            }
            else if (jet > 10)
            {
                jet++;
            }
            else if (jet < 5 )
            {
                jet--; ;
            }
            return jet;
        }
        public int AjustPv(int baseEnd)
        {
            if (baseEnd > 15)
            {
                return baseEnd + 2;
            }
            else if (baseEnd > 10)
            {
                return baseEnd + 1;
            }
            else if (baseEnd < 5)
            {
                return baseEnd - 1;
            }
            else
            {
                return baseEnd;
            }
        }

        public Personnage(string _name) 
        {
            this.Name = _name;
            this.BaseForce = BonusMalus();
            this.Force = BaseForce;
            this.BaseEndurance = BonusMalus();
            this.Endurance = BaseEndurance;
            this.PvMax =AjustPv(BaseEndurance);
            this.Pv =PvMax;
            
        }
        public void Frappe(Personnage cible)
        {
            Des des = new Des();
            int degat=des.Lance(4);

            if (this.Force > 15)
            {
                degat += 2;
                Console.WriteLine("Bras en titane : Dégat + 2 !");
            }
            else if (this.Force >10)
            {
                degat++;
                Console.WriteLine("Bras en acier : Dégat + 1 !");
            }
            else if (this.Force < 5)
            {
                degat--;
                Console.WriteLine("Bras en coton : Dégat - 1 !");
            }          
            cible.Pv = cible.Pv - degat;          
            Console.WriteLine($"Dégats infligés : {degat}");
        }
    }
}
