using System;
using System.Collections.Generic;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Помидор", "Бутмин", "Сисич", "Писич-Хуисич" , "nurguinjgrvgrenugw" };

            Console.WriteLine("Следующие имена имеют разные длины : ");
            foreach (string s in names)
            {
                Console.WriteLine("Имя '" + s + " ' до обработки");
            }
            Console.WriteLine();
            List<string> stringsToAlign = new List<string>();
            for (int i = 0; i < names.Count; i++)
            {
                {
                    string trimmedName = names[i].Trim();
                    stringsToAlign.Add(trimmedName);
                }
            }
            int maxLength = 0;
            foreach (string s in stringsToAlign)
            {
                if (s.Length > maxLength)
                {
                    maxLength = s.Length;
                }
            }
            for (int i = 0; i < stringsToAlign.Count; i++)
            {
                stringsToAlign[i] =
                   stringsToAlign[i].PadRight(maxLength + 1);
            }
            Console.WriteLine("Te же имена выровнены и" + " имеют одинаковую длину : ");
            foreach (string s in stringsToAlign)
            {
                Console.WriteLine("Имя '" + s + "' после обработки ");
            }
            Console.WriteLine("Haжмитe <Enter> для " + "завершения программы ... ");
            Console.Read();
        }
    }
}

