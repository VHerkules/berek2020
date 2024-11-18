using berek2020;
using System.Text;

List<Berek> berek = [];
using StreamReader sr = new("..\\..\\..\\src\\berek2020.txt", Encoding.UTF8);

sr.ReadLine();

while (!sr.EndOfStream)
{
    berek.Add(new(sr.ReadLine()));
}

Console.WriteLine($"3. feladat: Dolgozók száma: {berek.Count} fő");

var f4 = berek
    .Average(b => b.Ber);
Console.WriteLine($"4. feladat: Bérek átlaga: {f4 / 1000:0.0} eFt");

Console.Write("5. feladat: Kérem a részleg nevét: ");
string reszleg = Console.ReadLine();

int max = 0;
for (int i = 0;i< berek.Count; i++)
    if (berek[i].Reszleg == reszleg)
    {
        if (berek[i].Ber > berek[max].Ber) { max = i; }
    }
if (berek[max].Reszleg == reszleg)
{
    Console.WriteLine("6. feladat: A legtöbbet kereső dolgozó a megadott részlegen");
    Console.WriteLine($"\tNév: {berek[max].Nev}");
    Console.WriteLine($"\tNem: {berek[max].Nem}");
    Console.WriteLine($"\tBelépés: {berek[max].Belepes}");
    Console.WriteLine($"\tBér: {berek[max].Ber:0 000} Forint");
}
else Console.WriteLine("6. feladat: A megadott részleg nem létezik a cégnél!");

var f7 = berek
    .GroupBy(b => b.Reszleg);
Console.WriteLine("7. feladat: Statisztika");
foreach (var f in f7)
{
    Console.WriteLine($"\t {(f.Key)} - {(f.Count())} fő");
}