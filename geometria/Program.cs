using geometria;

Console.WriteLine("Inserisci la base del rettangolo: ");
int baseRettangolo = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del rettangolo: ");
int altezzaRettangolo = int.Parse(Console.ReadLine());

Rettangolo rettangoloUno = new Rettangolo(baseRettangolo, altezzaRettangolo);

int perimetroRettangolo = rettangoloUno.calcolaPerimetro(baseRettangolo, altezzaRettangolo);
int areaRettangolo = rettangoloUno.calcolaArea(baseRettangolo, altezzaRettangolo);

Console.WriteLine("-- Rettangolo --");
Console.WriteLine("Base: " + baseRettangolo);
Console.WriteLine("Altrezza: " +  altezzaRettangolo);
Console.WriteLine("Perimetro: " + perimetroRettangolo);
Console.WriteLine("Area: " + areaRettangolo);