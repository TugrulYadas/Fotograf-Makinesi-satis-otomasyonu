namespace _20232425043_tugrul_yadas
{
    internal class Program
    {

        static string[] dizi = new string[11];

        static void Main(string[] args)
        {   
            
            baslangic();
            cikti();
        }
        
        public static void baslangic()
        {
            Console.Write("İsim Giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Merhaba "+isim.ToUpper()+" Tc Oluşturma Sistemine Hoşgeldin");
            Console.WriteLine(" ");
            Console.WriteLine("Tc Oluşturuluyor...");
            System.Threading.Thread.Sleep(0000);

            tcolustur();

        }

        public static int ilkdeger()
        {
            Random random = new Random();
            int i = random.Next(1, 10);
            dizi[0] = Convert.ToString(i);
            return i;
            
        }

        static void cikti()
        {
            Console.WriteLine(tcolustur());
        }
        static int value = ilkdeger();
        static string tcolustur()
        {
            int sonSayi;
            Random random = new Random();
            while (true)
            {
                int toplam = value;
                
                for (int i = 1; i < 10; i++)
                {
                    int sayi = random.Next(0, 10);
                    
                    
                    toplam += sayi;
                    dizi[i] = Convert.ToString(sayi);
                }
             
                if (toplam%2 == 0)
                {
                   
                    sonSayi = toplam%10;
                   
                    dizi[10] = Convert.ToString(sonSayi);
                    
                    break;
                }
                
            }


            string tc = string.Join("", dizi);
            return tc;

        }
    }
}
