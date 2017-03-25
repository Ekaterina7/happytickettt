using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\new 1.txt");
           text = String.Join("", text.Split(',', '.'));
            Console.WriteLine(text);
            


            string[] textMass = text.Split(' ');
            Console.WriteLine("Количество слов:" + textMass.Length);
            System.IO.File.WriteAllText(@"C:\Users\Екатерина\Desktop\WriteText.txt", "Количество слов:" + textMass.Length);

            Console.WriteLine("Кол-во символов в тексте = " + text.Length);
            
            Console.WriteLine("Количество буквы " + Counter(text, "а"));
            double count = Counter(text, "а");
            double all = text.Length;

            Console.WriteLine("Процентное соотношение буквы ко всем символам = " + ProcentSootnochenie(all, count));
            Console.WriteLine();

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            System.IO.File.WriteAllText(@"C:\Users\Екатерина\Desktop\WriteText.txt",text+ "\r\n"+
                "\r\n" +"Количество слов:" + textMass.Length+ "\r\n"
                + "Процентное соотношение буквы ко всем символам = "+ 
                + ProcentSootnochenie(all, count)+ "\r\n"
                + "Кол-во символов в тексте = " + text.Length+ "\r\n"+ "\r\n"+
                text.ToLower()+ text.ToUpper());

        }
        static int Counter(string b, string a)
        {
            int count = 0;


            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == a[0])
                {
                    count++;
                }

            }
            return count;



        }

        static double ProcentSootnochenie(double all, double count)
        {
            return (count * 100) / all;

        }
    }
}
