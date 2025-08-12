using System.ComponentModel.Design;

string Ziyaretci_adi;
int Ziyaretci_yasi;
double Ziyaretci_boyu;
decimal Ziyaretci_bakiyesi;
bool ozel_macera_karti = true;

int MinYas = 16;
double MinBoy = 1.55;
decimal BiletFiyati = 30.80m;

Console.WriteLine("Ziyaretci adi: ");
Ziyaretci_adi = Console.ReadLine();
Console.WriteLine("-----");

Console.WriteLine("Ziyaretci yasi: ");
Ziyaretci_yasi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----");

Console.WriteLine("Ziyaretci boyu: ");
Ziyaretci_boyu = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-----");

Console.WriteLine("Ziyaretci nakit parasi: ");
Ziyaretci_bakiyesi = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("-----");

Console.WriteLine("Ozel macera kartiniz var mi: (true/false)");
ozel_macera_karti = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("-----");

Console.WriteLine("Giris Kontrolu");

if (Ziyaretci_yasi > MinYas && Ziyaretci_boyu > MinBoy)
{
    ;
}

Console.WriteLine($"Merhaba {Ziyaretci_adi}, yasiniz ve boyunuz hiz treni icin uygun.");

Console.WriteLine("Bilet ve Odeme Kontrolu");

if (Ziyaretci_bakiyesi >= BiletFiyati || ozel_macera_karti)
{
    decimal para_ustu = Ziyaretci_bakiyesi - BiletFiyati;
    Console.WriteLine($"Biletiniz alindi. Para ustunuz -> {para_ustu} TL. Iyi eglenceler.");
}

if (Ziyaretci_bakiyesi < BiletFiyati || ozel_macera_karti) ;
        Console.WriteLine("Ozel kart ile giris yaptiniz. Iyi eglenceler.");





