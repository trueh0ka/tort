using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Torts
{
    internal class Osnova
    {
        int position = 0;
        int page = 0;
        int price = 0;
        string opisaniezakaza;
        List<string> itog = new List<string>() { };
        Parametrs vse = new Parametrs();
        private void Vivod()
        {
            int indexer = 1;
            Console.Clear();
            Console.WriteLine("Выберите параметр торта: ");
            foreach (string i in vse.Osnovnie)
            {
                Console.WriteLine(i);
            }
        }
        public void Zakaz()
        {
            Console.SetCursorPosition(0, position);
            while (true)
            {
                Vivod();
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    Console.Clear();
                        Console.SetCursorPosition(0, position);
                        Vivod();
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                        key = Console.ReadKey();
                    }
                else if (key.Key == ConsoleKey.UpArrow)
                    {
                    if (position > 1)
                        {
                            position--;
                        Console.Clear();
                        Console.SetCursorPosition(0, position);
                        Vivod();
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                        key = Console.ReadKey();
                    }
                else if (key.Key == ConsoleKey.Enter)
                    {
                        if (page == 0)
                        {
                            switch (position)
                            {
                                case 1:
                                    Console.Clear();
                                    itog.Clear();
                                    foreach (string parametr in vse.Forma)
                                    {
                                        itog.Add(parametr);
                                    }
                                    page = 1;
                                    break;
                                case 3:
                                    itog.Clear();
                                    foreach (string parametr in vse.Razmer)
                                    {
                                        itog.Add(parametr);
                                    }
                                    page = 1;
                                    break;
                                case 4:
                                    itog.Clear();
                                    foreach (string parametr in vse.VkusKorzhs)
                                    {
                                        itog.Add(parametr);
                                    }
                                    page = 1;
                                    break;
                                case 5:
                                    itog.Clear();
                                    foreach (string parametr in vse.KolvoKorzhs)
                                    {
                                        itog.Add(parametr);
                                    }
                                    page = 1;
                                    break;
                                case 6:
                                    itog.Clear();
                                    foreach (string parametr in vse.Glazur)
                                    {
                                        itog.Add(parametr);
                                    }
                                    page = 1;
                                    break;
                                case 7:
                                    itog.Clear();
                                    foreach (string parametr in vse.Decor)
                                    {
                                        itog.Add(parametr);
                                    }
                                    page = 1;
                                    break;
                                case 8:
                                    Console.Clear();
                                    Console.WriteLine("Ваш заказ скоро будет готов");
                                    break;
                            }
                        }
                        else if (page == 1)
                        {

                        }
                    }
                }
                
            }
        }
    }
}
