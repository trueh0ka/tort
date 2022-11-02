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
        int position2 = 0;
        int page = 0;
        int price = 0;
        string opisaniezakaza;

        static Tortd tort = new Tortd();
        List<string> itog = new List<string>() { };
        Parametrs vse = new Parametrs();
        /// <summary>
        /// просто выводит все строки конкретного меню
        /// </summary>
        static ConsoleKey key = ConsoleKey.A;
        private void Vivod()
        {
            Console.Clear();
            Console.WriteLine("Выберите параметр торта: ");
            foreach (string i in vse.Osnovnie)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Торт: {tort.Form}\n{tort.Razmer}\n{tort.Vkus}\n" +
                $"{tort.KvoKorgey}\n{tort.Glazur}\n{tort.Decor}\n");
            key = Console.ReadKey().Key;
        }
        public void Zakaz()
        {
            Console.SetCursorPosition(0, position);
            Vivod();
            while (true)
            {

                if (key == ConsoleKey.DownArrow && page == 0)
                {
                    position++;
                    Console.Clear();
                    Console.SetCursorPosition(0, position);
                    Vivod();
                    Console.SetCursorPosition(0, position);
                    Console.Write("->");
                    key = Console.ReadKey().Key;
                }
                if (key == ConsoleKey.UpArrow && page == 0)
                {
                    if (position > 1)
                    {
                        position--;
                        Console.Clear();
                        Console.SetCursorPosition(0, position);
                        Vivod();
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                        key = Console.ReadKey().Key;

                    }
                }
                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    if (page == 0)
                    {
                        switch (position)
                        {
                            case 1:
                                Console.Clear();
                                page = 1;
                                p2();
                                break;
                            case 2:
                                Console.Clear();
                                page = 1;
                                p2();
                                break;
                            case 3:
                                Console.Clear();
                                page = 1;
                                p2();
                                break;
                            case 4:
                                Console.Clear();

                                page = 1;
                                p2();
                                break;
                            case 5:
                                Console.Clear();

                                page = 1;
                                p2();
                                break;
                            case 6:
                                Console.Clear();

                                page = 1;
                                p2();
                                break;
                            case 7:
                                Console.Clear();
                                Console.WriteLine("Ваш заказ скоро будет готов");
                                File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\tort.txt", $"Заказ от {DateTime.Now}\nТорт: {tort.Form}\n{tort.Razmer}\n{tort.Vkus}\n" +
                $"{tort.KvoKorgey}\n{tort.Glazur}\n{tort.Decor}\n");
                                System.Environment.Exit(0);
                                break;
                        }
                    }

                    key = Console.ReadKey().Key;

                }
            }
        }

        private void p2()
        {
            while (page == 1)
            {
                int y2 = position2;
                if (page == 1)
                {
                    if (key == ConsoleKey.DownArrow && page == 1)
                    {
                        position2++;
                        //Console.Clear();
                        Console.SetCursorPosition(0, y2);
                        Console.Write("   ");
                        Console.SetCursorPosition(0, position2);
                        Console.Write("->"+position2);
                        key = Console.ReadKey().Key;
                    }
                    if (key == ConsoleKey.UpArrow && page == 1)
                    {
                        if (position2 > 0)
                        {
                            position2--;
                            //Console.Clear();
                        Console.SetCursorPosition(0, y2);
                            Console.Write("   ");
                            Console.SetCursorPosition(0, position2);
                            Console.Write("->"+ position2);
                            key = Console.ReadKey().Key;

                        }
                    }
                    if(key == ConsoleKey.Escape)
                    {
                        page = 0;
                        position = 1;
                    }

                    switch (position)
                    {
                        case 1:
                            Console.SetCursorPosition(0, 0);
                            foreach (string parametr in vse.Forma)
                            {
                                Console.WriteLine("\t" + parametr);

                            }
                            if (key == ConsoleKey.Enter && position != vse.Forma.Count-1)
                            {
                                tort.Form = vse.Forma[position2];
                            }
                            break;

                        case 2:
                            Console.SetCursorPosition(0, 0);
                            foreach (string parametr in vse.Razmer)
                            {
                                Console.WriteLine("\t" + parametr);

                            }
                            if (key == ConsoleKey.Enter )
                            {
                                tort.Razmer = vse.Razmer[position2];
                            }
                            break;
                        case 3:
                            Console.SetCursorPosition(0, 0);
                            foreach (string parametr in vse.VkusKorzhs)
                            {
                                Console.WriteLine("\t" + parametr);

                            }
                            if (key == ConsoleKey.Enter )
                            {
                                tort.Vkus = vse.VkusKorzhs[position2];
                            }
                            break;
                        case 4:
                            Console.SetCursorPosition(0, 0);
                            foreach (string parametr in vse.KolvoKorzhs)
                            {
                                Console.WriteLine("\t" + parametr);

                            }
                            if (key == ConsoleKey.Enter )
                            {
                                tort.KvoKorgey = vse.KolvoKorzhs[position2];
                            }
                            break;
                        case 5:
                            Console.SetCursorPosition(0, 0);
                            foreach (string parametr in vse.Glazur)
                            {
                                Console.WriteLine("\t" + parametr);

                            }
                            if (key == ConsoleKey.Enter)
                            {
                                tort.Glazur = vse.Glazur[position2];
                            }
                            break;
                        case 6:
                            foreach (string parametr in vse.Decor)
                            {
                                Console.WriteLine("\t" + parametr);

                            }
                            if (key == ConsoleKey.Enter && position != vse.Decor.Count-1)
                            {
                                tort.Decor = vse.Decor[position2];
                            }
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Ваш заказ скоро будет готов");
                            
                            break;
                    }
                    key = Console.ReadKey().Key;
                }
            }
        }
    }
}