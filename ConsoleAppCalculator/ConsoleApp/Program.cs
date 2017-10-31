using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float nPrviBroj;
            float nDrugiBroj;
            float fRezultat = 0;
            int nOdabir;

            Console.WriteLine("Unesite prvi broj");
            nPrviBroj = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj");
            nDrugiBroj = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Odaberite opciju:");
            Console.WriteLine("1.zbrajanje");
            Console.WriteLine("2.mnozenje");
            Console.WriteLine("3.oduzimanje");
            Console.WriteLine("4.dijeljenje");

            nOdabir = Convert.ToInt16(Console.ReadLine());
            Calculator Calculator = new Calculator();
            switch(nOdabir)
            {
                case 1:
                    //fRezultat = nPrviBroj + nDrugiBroj;
                    Calculator.Add(nPrviBroj, nDrugiBroj);
                    break;
                case 2:
                    //fRezultat = nPrviBroj * nDrugiBroj;
                    Calculator.Multiply(nPrviBroj, nDrugiBroj);
                    break;
                case 3:
                    //fRezultat = nPrviBroj - nDrugiBroj;
                    Calculator.Substract(nPrviBroj, nDrugiBroj);
                    break;
                case 4:
                    //fRezultat = nPrviBroj / nDrugiBroj;
                    Calculator.Divide(nPrviBroj, nDrugiBroj);
                    break;
            }
            Console.WriteLine("Rezultat odabrane operacije je " + fRezultat);
            Console.ReadKey();
        }
    }
}
