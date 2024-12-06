using System;
using System.ComponentModel;
using System.Net;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;


namespace exp2
{
    /// <summary>
    /// Основной класс программы, содержащий метод Main.
    /// </summary>
    class Program
    {
        // Метод для вычисления произведения значений функции f для элементов массива T, попадающих в заданный диапазон

        /// <summary>
        /// Метод для проверки на значения функции на принадлежность к значению.
        /// </summary>
        /// <param name="func">Функция f (виртуальная или переопределённая).</param>
        /// <param name="T">Одномерный массив.</param>
        /// <param name="min">Минимальное значение диапазона.</param>
        /// <param name="max">Максимальное значение диапазона.</param>
        /// <returns>Произведение значений f, удовлетворяющих условию.</returns>
        public static double CalculateInOneDimentional(IBaseFunction func, List<int> T, double min, double max)
        {
            double product = 1;
            foreach (double element in T)
            {
                double fValue = func.f(element);
                // Проверка попадания значения f(T[i]) в заданный диапазон
                if (fValue >= min && fValue <= max)
                {
                    product *= fValue;
                }
            } 
            return product;
        }

        /// <summary>
        /// Исполняемый метод Main
        /// </summary>
        static void Main()
        {
            // Пример одномерного массива
            List<int> T = ExecuteFile.GetArrayFromFile("../../../readfile.txt");

            double min = 1;
            double max = 10;

            // Первый вызов с использованием функции f1
            BaseFunction1 baseFunc = new();
            double productF1 = CalculateInOneDimentional(baseFunc, T, min, max);
            ExecuteFile.SetResultToFile("../../../writefile.txt", $"Произведение значений f1 в диапазоне [{min}, {max}]: {productF1}");

            // Второй вызов с использованием функции f2
            BaseFunction2 derivedFunc = new();
            double productF2 = CalculateInOneDimentional(derivedFunc, T, min, max);
            ExecuteFile.SetResultToFile("../../../writefile.txt", $"Произведение значений f2 в диапазоне [{min}, {max}]: {productF2}");
        }
    }

    /// <summary>
    /// Интерфейс - инициализатор функции f
    /// </summary>
    interface IBaseFunction
    {
        /// <summary>
        /// инициализировать метод f
        /// </summary>
        /// <param name="x">принимаемое аргумент - число x</param>
        /// <returns></returns>
        double f(double x);
    }

    /// <summary>
    /// Первый базовый класс, реализация метода f = f1
    /// </summary>
    public class BaseFunction1 : IBaseFunction
    { 
        /// <summary>
        /// Переопределённый метод f = f1
        /// </summary>
        /// <param name="x">Аргумент функции</param>
        /// <returns>Квадрат числа x</returns>
        public double f(double x)
        {
            return Math.Pow(x, x);
        }
    }

    /// <summary>
    /// Второй базовый класс, реализация метода f = f2
    /// </summary>
    public class BaseFunction2 : IBaseFunction
    {
        /// <summary>
        /// Переопределённый метод f = f2
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Инкрементированное число x</returns>
        public double f(double x)
        {
            return Math.Log(x);
        }
    }



    /// <summary>
    /// Класс для чтения/записи файла.
    /// </summary>
    class ExecuteFile
    {
        /// <summary>
        /// Чтение файла path и получение значения чисел в формате списка.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns>Список значений из файла.</returns>
        public static List<int> GetArrayFromFile(string path)
        {
            List<int> array = new();
            StreamReader sr = new(path);
            Console.WriteLine("Чтение значений из файла {0}", path);
            string text = sr.ReadToEnd();
            string[] str = text.Split("\t");
            for (int i = 0; i < str.Length; i++)
            {
                array.Add(int.Parse(str[i]));
            }
            return array;
        }

        /// <summary>
        /// Запись результата вычислений в файл path.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="result">Строка, которая записывается в файл.</param>
        public static void SetResultToFile(string path, string result)
        {
            StreamWriter sw = new(path, true);
            Console.WriteLine("Запись результата в файл {0}", path);
            sw.WriteLine(result);
            Console.WriteLine("Результат записан в файл.");
            sw.Close();
        }
    }

}