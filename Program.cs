using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int liczba1 = 0;
            //Console.WriteLine(liczba1 / 0);  // Operacja niedozwolony nie mozna dzielic przez 0
            int liczba2, liczba3;
            liczba2 = 30;
            
            //liczba3 = liczba2 / liczba1;  // Po tej operacji aplikacja wyrzuci wyjatek 
            try
            {
                liczba3 = liczba2 / liczba1;
            }
            catch(Exception e)
            {
                Console.WriteLine("Nie mozna dzielic przez  0!");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.HelpLink);
                Console.WriteLine(e.Source);

            }
            finally
            {
                Console.WriteLine("Finally !!!");          // Jezeli wynik bylby mozliwy do uzyskania odpalony zostalby tylko blok finally
            }

            int []table=new int[3];
            try
            {
                table[25] = 2;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Po za zakresem tablicy");
            }
            */
            try
            {
                throw new IndexOutOfRangeException();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            //StackOverflowException  - przepelniony stos            /*             * NullReferenceException -
               FileNotFoundException-
               AccessViolationException-
               IndexOutOfRangeException -            */
            NaszWyjatekException Wyjatek = new NaszWyjatekException("BLAD");
            Console.WriteLine(Wyjatek.Message);

            Console.ReadKey();
        }
    }
}
