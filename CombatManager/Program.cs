using CombatManager.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatManager.Decorator.Inventory.Armour;
using CombatManager.Decorator.Inventory.MeleeWeapon;
using CombatManager.Decorator.Skills;

namespace CombatManager
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            RollingDie Hit = new RollingDie(100);
            RollingDie Damage = new RollingDie(10);
            #endregion
            #region PODSTAWA
            //---------------------------PODSTAWA----------------------------------------------------------------------------------
            //Creature smok = new Creature("smok", 65, 39, 8, 8, 55, 69, Hit, Damage, 1);
            //smok.PowerfulBlow(smok);


            ////---------------------wyciągnąć do klasy BATTLE-----------------------------------
            //for (int i = 0; i < 10; i++)
            //    smok.Attack();
            //smok.CrushingBlow(smok, Damage);

            //while (smok.CriticalHit())
            //{
            //    Console.WriteLine(smok.PrintZyw());


            //    Console.WriteLine("Wybierz akcję: ");
            //    Console.WriteLine("1 PARUJE");
            //    Console.WriteLine("2 UNIKA");
            //    Console.WriteLine("3 NIE MOŻE ? :D");

            //    int option = Convert.ToInt32(Console.ReadLine());

            //    if (option == 1)
            //    {
            //        if (!smok.Parry(smok, Hit))
            //        {
            //            Console.WriteLine("Smok nie sparował");
            //            Console.WriteLine("Wprowadź obrażenia");
            //            int val = Convert.ToInt32(Console.ReadLine());
            //            smok.TakeDamage(val);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Smok sparował");
            //        }
            //    }

            //    else if (option == 2)
            //    {
            //        if (!smok.DodgeBlow(smok, Hit))
            //        {
            //            Console.WriteLine("Smok nie uniknął");
            //            Console.WriteLine("Wprowadź obrażenia");
            //            int val = Convert.ToInt32(Console.ReadLine());
            //            smok.TakeDamage(val);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Smok uniknął");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wprowadź obrażenia");
            //        int val = Convert.ToInt32(Console.ReadLine());
            //        smok.TakeDamage(val);
            //    }
            //}
            #endregion
            #region Decorator test
            ICreature smok = new Creature("smok", 95, 39, 0, 0, 50, 69, Hit, Damage);
            CreatureDecorator armoured = new Kolcza(smok);
            CreatureDecorator creatureWeapon = new TwoHanded(armoured);
            CreatureDecorator creaturePowerful = new PowerfulBlow(creatureWeapon);
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Smok zadaje: " + creaturePowerful.Attack() + " obrażeń");
                creaturePowerful.TakeDamage(3);
                //Console.WriteLine(creaturePowerful.PrintZyw());

            }
            #endregion
        }
    }
}
