using System.Runtime.CompilerServices;

namespace HeroesVSMonsters.Models
{
    public class GamePlay
    {
        Monstre monstre = new Monstre("mob");
        Heros hero = new Heros("hero");
        

        public void Loot(Monstre monstre)
        {
            this.monstre = monstre;
            Des des = new Des();
            if (monstre.Name == "LOUP")
            {
                int cuir = des.Lance(4);
                Console.WriteLine($"Le Loup a loot {cuir} Cuirs !");
            }
            else if (monstre.Name == "ORQUE")
            {
                int or = des.Lance(6);
                Console.WriteLine($"L'Orque a loot {or} Ors !");
            }
            else if(monstre.Name == "DRAGONNET")
            {
                int or = des.Lance(6);
                int cuir = des.Lance(4);
                Console.WriteLine($"Le Dragonnet a loot {or} Ors et {cuir} Cuirs !");

            }  
        }
        public void RandMonster()
        {
            Des des = new Des();
            int a = des.Lance(3);
            if (a == 1)
            {
                this.monstre = new Loup("LOUP");
                Console.WriteLine("UN LEU VEUT VOUS BOUFFER LES MÎCHES MESSIRE !");
            }
            else if (a == 2)
            {
                this.monstre = new Orque("ORQUE");
                Console.WriteLine("UN MONTAGNE VERTE DE MUSCLE FONCE SUR VOUS !");
            }
            else
            {
                this.monstre = new Dragonnet("DRAGONNET");
                Console.WriteLine("UN SMAUG (de wish) EN VEUT A VOTRE OR !");
            }
        }
        public void JeuEntier()
        {
            Console.WriteLine("CHOOSE YOUR FIGHTER ! Êtes vous un humain (press 1) ou un nain (press 2) ?");
            int choixF;
            bool teuteu = int.TryParse(Console.ReadLine(), out choixF);


            while (choixF != 1 && choixF != 2 && !teuteu)
            {
                Console.WriteLine("TAPER 1 OU 2, RIEN D'AUTRE");
                teuteu = int.TryParse(Console.ReadLine(), out choixF);
            }
            if (choixF == 1)
            {
                Console.WriteLine("BIENVENUE DANS L'ARENE, HUMAIN !");
                Console.ReadKey();
                Console.WriteLine("Quel sera votre nom de héros ?");
                Humain humain = new Humain(Console.ReadLine());              
                Combat(humain, monstre);
            }
            else
            {
                Console.WriteLine("BIENVENUE DANS L'ARENE, NAIN !");
                Console.ReadKey();
                Console.WriteLine("Quel sera votre nom de héros ?");
                Nain nain = new Nain(Console.ReadLine());
                Combat(nain, monstre);
            }
        }
        public void Combat(Heros _hero, Monstre _monstre)
        {

            this.hero = _hero;
            this.monstre = _monstre;
            Console.WriteLine($"{hero.Name} stat : Pv : {this.hero.Pv} Force : {this.hero.Force} Endurance :{this.hero.Endurance}");
            Console.WriteLine();
            RandMonster();
            Console.ReadKey();
            Console.WriteLine($"{monstre.Name} stat : Pv : {this.monstre.Pv} Force : {this.monstre.Force} Endurance : {this.monstre.Endurance}");
            bool turnF = true;
            int monsterKill = 0;

            while ( this.hero.Pv > 0)
            {   
  
                if (turnF)
                {
                    Console.WriteLine();
                    Console.WriteLine($"   {hero.Name} FRAPPE");
                    hero.Frappe(this.monstre);
                    Console.WriteLine($"Pv restant de {monstre.Name} : {this.monstre.Pv}");
                    turnF = false;
                    
                }
                else if (!turnF)
                {
                    Console.WriteLine();
                    Console.WriteLine($"   LE {monstre.Name} FRAPPE");
                    monstre.Frappe(this.hero);
                    Console.WriteLine($"Pv restant du Héros : {this.hero.Pv}");
                    turnF = true;
                }

                if (hero.Pv <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("YOU ARE DEAD");
                    Music music = new Music();
                    music.TristeM();
                    Console.WriteLine($"Nombre de monstre mort : {monsterKill}");
                }
                else if (monstre.Pv <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("THE MONSTER IS DEAD");
                    Music music = new Music();
                    music.VictoryM();
                    Loot(monstre);
                    Console.ReadKey();                       
                    turnF = true;
                    Console.WriteLine("Vous vous reposez à l'auberge pour récupérer de vos blessures..");
                    Console.ReadKey();
                    this.hero.Pv=this.hero.PvMax;
                    Console.Clear();
                    Console.WriteLine("APPUYER SUR ENTER POUR CONTINUER LE BAIN DE SANG !") ;
                    Console.ReadKey();
                    RandMonster();
                    Console.WriteLine($"{monstre.Name} stat : Pv : {this.monstre.Pv} Force : {this.monstre.Force} Endurance : {this.monstre.Endurance}");
                    Console.WriteLine() ;
                    monsterKill++;
                }
                Console.ReadKey();
            }
        }
    }
}

