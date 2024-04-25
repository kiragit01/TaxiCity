﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCity
{
    internal class Program
    {
        /*Рассмотрим идеализированную модель Манхэттена (одного из районов Нью-Йорка): все улицы идут от одного края острова до другого, 
        все пересечения улиц происходят под прямым углом, и все кварталы имеют одинаковую длину.
        Иными словами, карта Манхэттена представляет собой прямоугольную решетку некоторого размера с фиксированным шагом, 
        где горизонтальные и вертикальные линии на карте — улицы, а их пересечения — перекрестки, на которых можно переходить с одной улицы на другую. 
        Пронумеруем горизонтальные улицы сверху. вниз начиная с единицы и аналогично пронумеруем слева направо вертикальные улицы. 
        Тогда каждый перекресток описывается двумя координатами (x, y) — номерами горизонтальной и вертикальной улиц. 
        Наша задача — помочь таксисту найти кратчайший путь между двумя заданными точками. 
        Известно, что таксист преодолевает каждый квартал за одну и ту же единицу времени, а повороты совершает мгновенно.
        В первой строке входных данных даны координаты (x1, y1) стартового перекрестка, во второй — координаты (x2, y2) 
        конечного перекрестка. Координаты — натуральные числа, не превосходящие 104. Вывести требуется длину кратчайшего пути.*/
        static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(x1-x2) + Math.Abs(y1-y2));
            Console.ReadKey();
        }
    }
}
