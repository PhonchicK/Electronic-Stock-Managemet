using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Electronic.Resistor
{
    public static class CalculateResistor
    {
        /*public static string ResistanceToString(int resistance)
        {
            if(resistance < 1000)
            {
                return string.Format()
            }
        }*/

        public static ResistorColor[] ResistanceToColors(double resistance, float tolerance, int stripCount)
        {
            int powerValue = 0;

            // Direnç değerinin 1, 10, 100, 1000, 10000 vb. olmasını sağlar
            while (resistance % 10 == 0)
            {
                resistance /= 10;
                powerValue++;
            }

            ResistorColor[] colors = new ResistorColor[stripCount];

            // İlk iki renk, direncin değerini verir
            colors[0] = (ResistorColor)(resistance / 10);
            colors[1] = (ResistorColor)(resistance % 10);

            // Üçüncü renk, direncin kat değerini verir
            colors[2] = (ResistorColor)powerValue;

            // Dördüncü renk, tolerans değerini verir
            colors[3] = ResistorColor.Gold;
            return colors;
        }
    }
}
