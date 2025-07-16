using System;
using System.Collections.Generic;

class Harcama
{
    public String aciklama { get; set; }
    public decimal tutar { get; set; }
    public DateTime tarih { get; set; }
    public string Kategori { get; set; }
}

partial class Program
{
    static List<Harcama> harcamalar = new List<Harcama>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n-- Harcama Takip --");
            Console.WriteLine("1. Harcama Ekle");
            Console.WriteLine("2. Harcamaları Listele");
            Console.WriteLine("3. Toplam Harcama");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçim: ");
            var secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    HarcamaEkle();
                    break;
                case "2":
                    HarcamalariListele();
                    break;
                case "3":
                    ToplamHarcama();
                    break;
                case "4":
                    Console.WriteLine("Çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }

    static void HarcamaEkle()
    {
        Console.Write("AÇIKLAMA:");
        String aciklama = Console.ReadLine();
        Console.Write("TUTAR:");
        decimal tutar = decimal.Parse(Console.ReadLine());
        Console.Write("Kategori: ");
        string kategori = Console.ReadLine();
        harcamalar.Add(new Harcama { aciklama = aciklama, tutar = tutar, tarih = DateTime.Now });
        Console.WriteLine("Harcama kaydedildi.");
    }

    static void HarcamalariListele()
    {
        Console.WriteLine("\n--- Harcamalar ---");
        foreach (var h in harcamalar)
        {
            Console.WriteLine($"{h.Tarih:yyyy-MM-dd HH:mm} - {h.Aciklama} ({h.Kategori}) : {h.Tutar} TL");

        }
    }

    static void ToplamHarcama()
    {
        decimal toplam = 0;
        foreach (var h in harcamalar) toplam += h.tutar;
        Console.WriteLine($"\nToplam Harcama: {toplam} TL");
    }
}