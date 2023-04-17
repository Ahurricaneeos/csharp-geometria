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

        public int calcolaArea(int baseRettangolo, int altezzaRettangolo)
        {
            int areaRettangolo = (this.baseRettangolo * this.altezzaRettangolo);
            return areaRettangolo;
        }

        public int calcolaPerimetro(int baseRettangolo, int altezzaRettangolo)
        {
            int perimetroRettangolo = ((this.altezzaRettangolo + this.baseRettangolo) * 2);
            return perimetroRettangolo;
        }
    }
}
