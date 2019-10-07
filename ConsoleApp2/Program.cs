using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Seriennummer, nochmal;
            do
            {
                bool eingabeprüfung = true;

                // string str = " Hallo"
                // str[0] ="h";
                // str.Length

                do
                {
                    Console.WriteLine("Seriennummer der Banknoten eingeben:");
                    Seriennummer = Console.ReadLine().ToUpper();
                    if (Seriennummer.Length != 12)
                    {
                        Console.WriteLine("Die Seriennummer hat nicht die richtige Länge");
                        eingabeprüfung =true;
                    }
                    else if (char.IsLetter(Seriennummer[0]) == false || char.IsLetter(Seriennummer[1]) == false)

                    {
                        Console.WriteLine("Die ersten beiden Zeichen müssen Buchstaben sein.");
                        eingabeprüfung = false;
                    }
                    else if (Regex.IsMatch( Seriennummer.Substring(2, Seriennummer.Length-2),"^[0-9]+$")==false)

                        {
                        Console.WriteLine("Die letzten zehn zeichen müssen Ziffern sein");
                        eingabeprüfung = false;


                    }
                    else
                    {
                        Console.WriteLine("Folgende Seriennummer wird geprüft :" + Seriennummer);
                        eingabeprüfung = true;

                    }
                } while (!eingabeprüfung );
                int summe, stelle1, stelle2;
                stelle1 = Convert.ToInt32(Seriennummer[0])-64;
                stelle2 = Convert.ToInt32(Seriennummer[1])- 64;
                summe = stelle1 + stelle2; 
                for (int i=2; i < Seriennummer.Length; i++)
                {
                    summe +=Convert.ToInt32(Convert.ToString( Seriennummer[i]));
                }
                Console.WriteLine("Umwandlung: " + stelle1);

                Console.WriteLine(" Soll noch eine Seriennummer geprüft werden (j/n)");
                nochmal = Console.ReadLine();
            } while (nochmal =="j");





        }
    }
}
