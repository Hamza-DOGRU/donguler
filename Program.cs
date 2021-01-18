using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //array=Diziler
            string[] kurslar = new string[] {"Yazılım Gelişrici Kampı",
                "Programlama","Java","python","C++" };
            //Döngü Yazma
            for (int i = 0; i < kurslar.Length; i++)//0 dan başla kurslar dizisinin son elemanına kadar devam et
                
            {
                Console.WriteLine(kurslar[i]);//kursların i ninci elemanını yazdır.

            }
            //dizileri yazmanın başka şekli daha kolayı
            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek döner. Kursları tek tek dolaş demektir.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu-Footer");
        }
    }
}
