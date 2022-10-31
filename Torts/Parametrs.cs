using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torts
{
    internal class Parametrs
    {
        public List<string> Osnovnie = new List<string>()
        {
            "  Форма торта",
            "  Размер торта",
            "  Вкус коржей",
            "  Количество коржей",
            "  Глазурь",
            "  Декор",
            "  Конец заказа",
        };
        public List<string> Forma = new List<string>()
        {
            "  Круг - 500",
            "  Квадрат - 500",
            "  Прямоугольник - 500",
            "  Сердечко - 700"
        };
        public List<string> Razmer = new List<string>()
        {
            "  Маленький (Диаметр - 16см, 8 порций) - 1000",
            "  Обычный (Диаметр - 18см, 10 порций) - 1200",
            "  Большой (Диаметр - 28см, 24 порций) - 2000",
        };
        public List<string> VkusKorzhs = new List<string>()
        {
            "  Ванильный - 100",
            "  Шоколадный - 100",
            "  Карамельный - 150",
            "  Ягодный - 200",
            "  Кокосовый - 250",
        };
        public List<string> KolvoKorzhs = new List<string>()
        {
            "  1 корж - 200",
            "  2 корж - 400",
            "  3 корж - 600",
            "  4 корж - 800",
        };
        public List<string> Glazur = new List<string>()
        {
            "  Шоколад - 100",
            "  Крем - 100",
            "  Бизе - 150",
            "  Драже - 150",
            "  Ягоды - 200",
        };
        public List<string> Decor = new List<string>()
        {
            "  Шоколадная - 150",
            "  Ягодная - 150",
            "  Кремовая - 150",
        };
    }
}
