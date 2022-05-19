using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szyfr_Cezara
{
    class Program
    {
        public static char szyfr(char ch, int klucz)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + klucz) - d) % 26) + d);
        }

        public static string zaszyrfruj(string text, int klucz)
        {
            string reg = string.Empty;
            foreach (char ch in text)
                reg += szyfr(ch, klucz);
            return reg;
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj tekst który chcesz zaszyfrować: ");
            string text = Console.ReadLine();
            Console.Write("Podaj klucz: ");
            int klucz = Int32.Parse(Console.ReadLine());
            string poszyfrowaniu = zaszyrfruj(text, klucz);
            Console.WriteLine(poszyfrowaniu);
        }
    }
}
