namespace SINAV_INTRO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Giris();
            AdımCmAl();
            DkAdımSayısı();
            BilgiVer();
            KosuSuresiSaat();
            KosuSuresiDakika();
            Cozum();

        }

        static double adımcm, adımsayısı, saat, dakika, sonuc, saatcevir, toplamsure;

        static void Giris()
        {
            Console.WriteLine("*****Koşu Mesafesi Ölçer*****");
            Console.WriteLine("Bir adımınızın ortalama uzunluğu, dakikada attığınız adım sayısı ve koşu süresi bilgilerini hazırlayınız.");
        }

        static void AdımCmAl()
        {
            Console.Write("Bir adımınızı giriniz(cm):");
            try  //harf girişi ve sıfırdan küçük girişleri kontrol 
            {
                adımcm = double.Parse(Console.ReadLine());
                if (adımcm <= 0)
                {
                    Console.WriteLine("Adım uzunluğu sıfırdan küçük olamaz");
                    AdımCmAl();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                AdımCmAl();
            }
        }

        static void DkAdımSayısı()
        {
            Console.Write("Bir dakikada kaç adım attığınızı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out adımsayısı) && adımsayısı > 0) //harf girişi ve sıfırdan küçük girişleri kontrol
            { }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyin.");
                DkAdımSayısı();
            }
        }

        static void BilgiVer()
        { Console.WriteLine("Koşu sürenizi saat ve dakika olmak üzere ayrı girişlerde giriniz."); }

        static void KosuSuresiSaat()
        {

            Console.Write("Saat: ");
            if (double.TryParse(Console.ReadLine(), out saat) && saat >= 0 && saat <= 24) //harf girişi ve sıfırdan küçük girişleri ve 24 saati geçmemesi için kontrol
            { saatcevir = saat * 60; }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyin.");
                KosuSuresiSaat();
            }
        }

        static void KosuSuresiDakika()
        {
            Console.Write("Dakika: ");
            if (double.TryParse(Console.ReadLine(), out dakika) && dakika >= 0 && dakika <= 59) //harf girişi ve sıfırdan küçük girişleri ve 59 dakikayı geçmemesi için kontrol
            { toplamsure = saatcevir + dakika; }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyin.");
                KosuSuresiDakika();
            }
        }

        static void Cozum()
        {
            sonuc = ((toplamsure) * adımsayısı * (adımcm / 100));
            Console.WriteLine($"{sonuc} metre koştunuz.");
            Console.WriteLine("Çıkmak için exit yazınız.");
            string cıkıs = Console.ReadLine();
            if (cıkıs == "exit")
                Environment.Exit(0);
            else
                AdımCmAl();
        }

    }
}

