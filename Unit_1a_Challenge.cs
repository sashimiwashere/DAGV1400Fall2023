using System; 

namespace Unit_1a_Challenge
{
    class MachineGun
    {
        static void Main(string[] args)
        {
            string gun = "AK-47";
            
            int ammo = 12;

            double health = 100.0;  // I fix it to double because after gun fight health have a decimal the program will run in to error

            int LifePack = 50;

            double DamgeHead = 25.5;

            double DeamgeBody = 10.5;


            
            
            ammo--;     // ammo use per click
            Console.WriteLine(gun + " has " + ammo + " left");    // ammo left

            Console.WriteLine(health - DamgeHead - (DeamgeBody*5));     // health after 1 headshot 5 bodyshots

            health = 22;    
            Console.WriteLine(health + LifePack);   // health after grab a lifepack

            health = 72;
            Console.WriteLine(health - (DamgeHead*2 + DeamgeBody*3));    //health after another gun fight

            health = -10.5;     // current health
            Console.WriteLine(health >= 1);     // is health greater or equal to 1?

            Console.WriteLine("Did he surrvied that gun fight?");

            Console.WriteLine("type in your answear yes/no");

            Console.ReadLine();



        }
    }
}
