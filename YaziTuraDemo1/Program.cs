namespace YaziTuraDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yazı (y) mı tura (t) mı çıkış(ç) ?");

            string giris = Console.ReadLine();

            Random rastgele = new Random();
            int sayi;
            int yaziTura;

            double oynamaSayisi = 0;
            double bilmeSayisi = 0;

            while (giris != "ç")
            {
                sayi = rastgele.Next(0, 2);  // 0,1

                //yaziTura = 0;
                //if (giris == "t")
                //    yaziTura = 1;

                yaziTura = giris == "y" ? 0 : 1;

                if (yaziTura == sayi)
                {
                    Console.WriteLine("Bildiniz");
                    bilmeSayisi++;
                }
                else
                {
                    Console.WriteLine("Bilmediniz");
                }

                Console.Write("yazı mı (y) tura mı (t) çıkış (ç)");
                giris = Console.ReadLine();
                oynamaSayisi++;
            }
            if (oynamaSayisi > 0)
            {
                double sans = bilmeSayisi * 100 / oynamaSayisi;

                if (sans >= 50)
                    Console.WriteLine("Sanslısın (" + sans + ")");
                else
                    Console.WriteLine("Kotu sans (" + sans + ")");
            }
        }
    }
}