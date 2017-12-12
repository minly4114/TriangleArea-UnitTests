using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangle
{
    public class ClassAreaTriangle
    {
        double cathetus1, cathetus2, hypotenuse, area;
        public ClassAreaTriangle(double cathetus1, double cathetus2, double hypotenuse)
        {
            this.cathetus1 = cathetus1;
            this.cathetus2 = cathetus2;
            this.hypotenuse = hypotenuse;
        }
        /// <summary>
        /// Метод который проверяет, по имеющимся данным, с помощью теоремы Пифагора является ли данный треугольник прямоугольным
        /// </summary>
        /// <returns> Возвращает true, если треугольник прямоугольный</returns>
        public bool CheckForSquareness()
        {
            if (hypotenuse != 0 && cathetus1 != 0 && cathetus2 != 0)
            {
                if (hypotenuse * hypotenuse == (cathetus1 * cathetus1 + cathetus2 * cathetus2))
                {
                    return true;
                }
                else return false;
            }
            else return true;
        }

        /// <summary>
        /// Метод, вычисляющий площадь, по имеющимся данным.
        /// </summary>
        /// <returns>Возвращает площадь</returns>
        public double CountArea()
        {
            if(cathetus1<0||cathetus2<0||hypotenuse<0)
            {
                return -1;
            }
            else if (cathetus1 != 0 && cathetus2 != 0)
            {
                area = cathetus1 * cathetus2 * 0.5;
            }
            else if (cathetus1 != 0 && hypotenuse != 0)
            {
                area = Math.Sqrt(hypotenuse * hypotenuse - cathetus1 * cathetus1) * cathetus1 * 0.5;
            }
            else if (cathetus2 != 0 && hypotenuse != 0)
            {
                area = Math.Sqrt(hypotenuse * hypotenuse - cathetus2 * cathetus2) * cathetus2 * 0.5;
            }
            else
            {
                area = 0;
            }
            return area;
        }
    }
}
