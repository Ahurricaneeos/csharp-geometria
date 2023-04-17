using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometria
{
    public class Rettangolo
    // Attributi
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        // Costruttore - Parametri
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        // Metodi

        public int calcolaArea()
        {
            int areaRettangolo = (this.baseRettangolo * this.altezzaRettangolo);
            return areaRettangolo;
        }

        public int calcolaPerimetro()
        {
            int perimetroRettangolo = ((this.altezzaRettangolo + this.baseRettangolo) * 2);
            return perimetroRettangolo;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine("-- Rettangolo --");
            Console.WriteLine("Base: " + baseRettangolo + "cm");
            Console.WriteLine("Altrezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Perimetro: " + calcolaPerimetro() + "cm");
            Console.WriteLine("Area: " + calcolaArea() + "cm2");
        }
        public void disegnaRettangolo()
        {
            string asseX = "--";
            string asseY = "|";

            Console.WriteLine(" ");
            Console.Write(" ");

            // Lato superiore

            for (int i = 0; i < baseRettangolo - 1; i++) 
            {
              Console.Write(asseX);
            }

            Console.WriteLine(asseX);
            
            // Lati laterali

            for (int i = 0; i < altezzaRettangolo; i++)
            {
              Console.Write(asseY);

               for (int j = 0; j < baseRettangolo; j++) 
               {
                  Console.Write("  ");
               }

              Console.WriteLine(asseY);
            }

            Console.Write(" ");
            
            // Lato inferiore

            for (int i = 0; i < baseRettangolo - 1; i++)
            {
               Console.Write(asseX);
            }

            Console.WriteLine(asseX);

        }
    }
}
