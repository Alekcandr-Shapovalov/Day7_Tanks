using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        protected string name;
        protected int ammunition;
        protected int armor;
        protected int maneuver;
        public Tank(int ammunition, int armor, int maneuver, string name)
        {

            this.ammunition = ammunition;
            this.armor = armor;
            this.maneuver = maneuver;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine("Танк - " + name + "   Боекомплект - " + ammunition + " Броня - " + armor + " Маневреность - " + maneuver);           
        }

        public static string operator *(Tank T34, Tank Pantera)
        {
            if (T34.ammunition + T34.armor + T34.maneuver > Pantera.ammunition + Pantera.armor + Pantera.maneuver)
            {
                return T34.name;
            }
            else
            {
                return Pantera.name;
            }
        }
    }
}
