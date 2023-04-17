using geometria;

Console.WriteLine("Inserisci la base del rettangolo: ");
int baseRettangolo = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del rettangolo: ");
int altezzaRettangolo = int.Parse(Console.ReadLine());

Rettangolo rettangoloUno = new Rettangolo(baseRettangolo, altezzaRettangolo);
Rettangolo rettangoloDue = new Rettangolo(20, 15);

int perimetroRettangolo = rettangoloUno.calcolaPerimetro();
int areaRettangolo = rettangoloUno.calcolaArea();

rettangoloUno.stampaRettangolo();
rettangoloDue.stampaRettangolo();