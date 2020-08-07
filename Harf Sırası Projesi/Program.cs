using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harf_Sırası_Projesi0
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            String gelensayi;
            Console.WriteLine("Kelimelerinizi girin.Bütün kelimeler bitince 0 giriniz.");
            Console.WriteLine();

            do
            {

                gelensayi = Console.ReadLine();
                if (gelensayi != "0")
                {
                    liste.Add(gelensayi);
                }

            }while (gelensayi != "0");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Kelimeler eklendi.Toplamda " + liste.Count + " kelime eklendi.");
            Console.WriteLine("***************************************************************************");
            //Burada yükleniyor... tarzı bir şeyler yapılabilir.
            ornekmetot(liste);
           
        }

        static void ornekmetot(ArrayList gListe)
        {
            Console.WriteLine("Sıralanmış Kelimeleriniz : ");
            Console.WriteLine();
            gListe.Sort();
            int sayı = 1;
            foreach (var item in gListe)
            {
                Console.WriteLine(sayı+"-" +item);
                sayı++;
            }

            Console.Read();
        }
 
        
    }
}
