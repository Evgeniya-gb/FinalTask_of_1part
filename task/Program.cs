using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаем первоначальный массив на старте прграммы
            //string[] arr = {"1234", "1567", "-2", "computer science" };
            string[] arr = { "hello", "2", "world", ":-)" };
            //string[] arr = { "Russia", "Denmark", "Kazan" };
            //Сначала находим сколько строк в массиве, длина которых меньше либо равна 3, чтобы знать какой длины нужен формируемый массив
            int n = 0;     //исходная длина массива равна 0
            for (int i = 0; i < arr.Length; i++)    //в цикле
            {
                if (arr[i].Length <= 3)             //проверяем если длина очередной строки меньше либо равна 3
                    n++;                            //увеличиваем n
            }
            string[] newarr = new string[n];        //создаем массив нужной длины
            //и переносим строки , длина которых меньше либо равна 3 из первоначального массива в новый
            int j = 0;      //индекс очередной строки в новом массиве
            for (int i = 0; i < arr.Length; i++)        //цикл переноса
            {
                if (arr[i].Length <= 3)         //проверяем если длина очередной строки меньше либо равна 3
                {
                    newarr[j] = arr[i];         //то переносим ее в новый массив
                    j++;                        //и увеличиваем индекс очередной строки в новом массиве
                }
            }
            //выводим сформированный массив
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(newarr[i]);
            }
            Console.ReadKey();
        }
    }
}

