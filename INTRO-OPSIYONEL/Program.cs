using System.Diagnostics.Metrics;

namespace INTRO_OPSIYONEL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opsiyonel Soru:Koşuyu bir parkurun etrafında 5 kere koşuyorum. Tüm turları aynı hızda koşmam mümkün olmayacağından her turun sonunda turu koştuğum süreyi kayıt altına almak istiyorum.Koşunun sonunda koştuğun turları en hızlıdan yavaşa doğru sıralayabilir misiniz.

            Basla();
            Sırala();
            Cıkıs();
        }

        static int[] parkur = new int[5];
        static int sure;

        static void Basla()
        {
            Console.WriteLine("Lütfen süreyi dakika cinsinden giriniz.");
            for (int i = 0; i < parkur.Length; i++)
            {
                Console.Write($"{i + 1}. turu giriniz: ");
                if (int.TryParse(Console.ReadLine(), out sure) && sure > 0 && sure <= 1440) //surenin int olduğunu, sıfırdan küçük olmaması ve dakika cinsinden 24 saati geçmemesi kontrolü  
                { parkur[i] = sure; }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Tekrar deneyiniz.");
                    Basla();
                }
            }
        }

        static void Sırala()
        {
            Array.Sort(parkur);
            foreach (int i in parkur) 
            { 
                Console.WriteLine(i);
            }
            Console.WriteLine($"En hızlı: {parkur[0]} DK \nEn yavaş: {parkur[4]} DK");
        }

        static void Cıkıs()
        {
            Console.WriteLine("Çıkmak isterseniz exit yazın.");
            string cevap = Console.ReadLine();
            if (cevap == "exit")
                Environment.Exit(0);
            else 
            {
                Console.WriteLine("Başlangıç noktasına yönlendiriliyorsunuz....");
                Basla();
            }

        
        }
    }
}
