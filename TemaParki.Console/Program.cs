// TODO: yerel degiskenler camelCase tanimlanir. Gerekli duzeltmeleri yap. Ama BugFix/branch acilarak o branch uzeride gerekli duzenlemeler yapilmalidir. 

public class ParkZiyaretcisi
{
    public string AdiSoyadi { get; set; } 
    public int Yasi { get; set; }
    public double Boyu { get; set; } // TODO: double icin odevlerden gerekli yeri oku.
    public decimal Bakiyesi { get; set; }
    public bool OzelMaceraKarti { get; set; }
}

int MinYas = 16;
double MinBoy = 1.55;
decimal BiletFiyati = 30.80m;

Console.Write("Ziyaretci adi: ");
ParkZiyaretcisi.AdiSoyadi = Console.ReadLine();
Console.WriteLine("-----");

Console.Write("Ziyaretci yasi: ");
Ziyaretci_yasi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----");

Console.Write("Ziyaretci boyu: ");
Ziyaretci_boyu = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-----");

Console.Write("Ziyaretci nakit parasi: ");
Ziyaretci_bakiyesi = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("-----");

Console.Write("Ozel macera kartiniz var mi: (true/false) ");
ozel_macera_karti = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("-----");

Console.WriteLine("Giris Kontrolu");

if (Ziyaretci_yasi > MinYas && Ziyaretci_boyu > MinBoy)
{
    Console.WriteLine($"Merhaba {Ziyaretci_adi}, yasiniz ve boyunuz hiz treni icin uygun.");
}

else if (Ziyaretci_yasi < MinYas) 
{
    Console.WriteLine("Yasiniz kucuk. Iceri giremezsiniz, uzgunuz.");
}

if (Ziyaretci_boyu < MinBoy) 
{
    Console.WriteLine("Boyunuz kucuk. Iceri giremezsiniz, uzgunuz.");
}

Console.WriteLine("\nBilet ve Odeme Kontrolu\n");

if (Ziyaretci_bakiyesi < BiletFiyati && ozel_macera_karti == false)
{
    Console.WriteLine("Bilet alabilmek icin yeterli bakiyeniz ve ozel macera kartiniz yok. Iceri giremezsiniz, uzgunuz.");
}
else if (Ziyaretci_bakiyesi >= BiletFiyati || ozel_macera_karti == false)
{
    decimal para_ustu = Ziyaretci_bakiyesi - BiletFiyati;
    Console.WriteLine($"Biletiniz alindi. Para ustunuz -> {para_ustu} TL. Iyi eglenceler.");
}

else if (Ziyaretci_bakiyesi < BiletFiyati || ozel_macera_karti == true)
{
    Console.WriteLine("Ozel kart ile giris yaptiniz. Iyi eglenceler.");
}

        





