using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            double cathetus1, cathetus2, hypotenuse, area;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите катет1, катет2, гипотенузу через Enter, если вы не знаете какое-либо значение, то введите 0");
            cathetus1 = DataEnter();
            cathetus2 = DataEnter();
            hypotenuse = DataEnter();
            ClassAreaTriangle cat = new ClassAreaTriangle(cathetus1, cathetus2, hypotenuse);
            if (cat.CheckForSquareness())
            {
                area = cat.CountArea();
                if (area < -1)
                {
                    Console.WriteLine("Площадь прямоугольного треугольника = " + area);
                }
                else Console.WriteLine("Площадь прямоугольного треугольника не найдена = " + area);
            }
            else Console.WriteLine("Вы задали не прямоугольный треугольник!");
            Console.ReadLine();
        }
        /// <summary>
        /// Метод реализующий введение данных
        /// </summary>
        /// <returns>Возращает введённые значения в формате double </returns>
        public static double DataEnter()
        {
            double data;
            while(true)
            {
                try
                {
                    data = Convert.ToDouble(Console.ReadLine());
                    if (data >= 0)
                    {
                        break;
                    }
                    else Console.WriteLine("Данное Значение не должно быть отрицательным,введите данное значение повторно!");
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный ввод данных, введите данное значение повторно!");
                }
            }
            return data;

        }
    }
}
