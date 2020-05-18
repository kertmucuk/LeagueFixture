using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_fixture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Takim Sayisini Giriniz");
            int takimsayisi = Convert.ToInt32(Console.ReadLine());
            leagueFixture(takimsayisi);
            Console.ReadKey();
        }
        public static void leagueFixture(int takim_sayisi)
        {

            // Kaç round sonrası lig tamamlanacak
            int roundCount = takim_sayisi - 1;
            // Bir round'da ne kadar maç oynanır
            int matchCountPerRound = takim_sayisi / 2;

            List<int> list = new List<int>();

            // Takim listesini oluşturuyoruz. 
            for (int i = 0; i < takim_sayisi; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < roundCount; i++)
            {
                Console.WriteLine(i + ".nci Round:");
                for (int j = 0; j < matchCountPerRound; j++)
                {
                    int firstIndex = j;
                    int secondIndex = (takim_sayisi - 1) - j;
                    Console.WriteLine(list[firstIndex] + "-" + list[secondIndex]);
                }
                // İlk eleman sabit olacak şekilde elamanları kaydırıyoruz
                List<int> newList = new List<int>();

                // İlk eleman sabit
                newList.Add(list[0]);

                // Son eleman ikinci eleman yapıyoruz.
                newList.Add(list[list.Count - 1]);

                for (int k = 1; k < list.Count - 1; k++)
                {
                    newList.Add(list[k]);
                }
                // Kaydırılan liste yeni liste oluyor.
                list = newList;
            }
            Console.WriteLine("Toplam Round Sayısı : " + roundCount);
            Console.WriteLine("Bir Round'daki Maç Sayısı:  " + matchCountPerRound);

        }
    }
}
