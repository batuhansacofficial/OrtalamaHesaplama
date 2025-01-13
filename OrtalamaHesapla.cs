using System;
using System.Collections.Generic;

public class FibonacciSinif
{
    public List<int> FibonacciOlustur(int derinlik)
    {
        List<int> fibonacciListesi = new List<int>();
        int a = 0, b = 1;
        
        for (int i = 0; i < derinlik; i++)
        {
            fibonacciListesi.Add(a);
            int sonraki = a + b;
            a = b;
            b = sonraki;
        }
        
        return fibonacciListesi;
    }
}

public class OrtalamaSinif
{
    public double OrtalamaHesapla(List<int> sayilar)
    {
        if (sayilar.Count == 0)
            throw new ArgumentException("Sayi listesi bos olamaz.");
        
        double toplam = 0;
        foreach (var sayi in sayilar)
        {
            toplam += sayi;
        }
        
        return toplam / sayilar.Count;
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Fibonacci serisinin derinligini girin: ");
        int derinlik = int.Parse(Console.ReadLine());

        var fibonacciSinif = new FibonacciSinif();
        var ortalamaSinif = new OrtalamaSinif();

        List<int> fibonacciSayilar = fibonacciSinif.FibonacciOlustur(derinlik);

        double ortalama = ortalamaSinif.OrtalamaHesapla(fibonacciSayilar);
        
        Console.Write("Fibonacci Sayilari: ");
        foreach (var sayi in fibonacciSayilar)
        {
            Console.Write(sayi + " ");
        }
        
        Console.WriteLine();
        Console.WriteLine("Fibonacci Sayilari ortalamasi: " + ortalama);
    }
}