using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("lütfen aşağıdaki bilgileri doldurunuz");


        Console.Write("T.C. Kimlik Numaranızı Girin: ");
        string tcKimlikNo = Console.ReadLine();

        Console.Write("Adınızı Girin: ");
        string ad = Console.ReadLine();

        Console.Write("Soyadınızı Girin: ");
        string soyad = Console.ReadLine();

        Console.Write("Telefon Numaranızı Girin: ");
        string telefon = Console.ReadLine();

        Console.Write("Yaşınızı Girin: ");
        int yas = int.Parse(Console.ReadLine());

        Console.Write("Birinci ürünün fiyatını girin: ");
        double urun1Fiyati = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci ürünün fiyatını girin: ");
        double urun2Fiyati = Convert.ToDouble(Console.ReadLine());

        double toplam = urun1Fiyati + urun2Fiyati;

        double indirimTutari = toplam * 0.10;

        Console.WriteLine("-------------------------");

        Console.WriteLine($"{tcKimlikNo} tc kimlik nolu {ad} {soyad} isimli kişi için kayıt oluşturulmuştur");
        Console.WriteLine($"{telefon} telefon numarasına bildirim gönderilmiştir");
        Console.WriteLine($"{toplam} toplam harcama karsılıgı kazanılan %10 patika puan miktarı --> {indirimTutari} TL");
    }
    
}

 



























