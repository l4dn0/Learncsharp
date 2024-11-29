using System;
using System.ComponentModel;
using System.Net;
using System.Numerics;
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
        public static double CalculateInOneDimentional(BaseFunction func, double[] T, double min, double max)
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
            double[] T = { 1, 2, 3, 4, 5 };
            double min = 1;
            double max = 10;

            // Первый вызов с использованием функции f1
            BaseFunction baseFunc = new BaseFunction();
            double productF1 = CalculateInOneDimentional(baseFunc, T, min, max);
            Console.WriteLine($"Произведение значений f1 в диапазоне [{min}, {max}]: {productF1}");

            // Второй вызов с использованием функции f2
            DerivedFunction derivedFunc = new DerivedFunction();
            double productF2 = CalculateInOneDimentional(derivedFunc, T, min, max);
            Console.WriteLine($"Произведение значений f2 в диапазоне [{min}, {max}]: {productF2}");
        }
    }

    /// <summary>
    /// Базовый класс, содержащий виртуальный метод
    /// </summary>
    public class BaseFunction
    {
        /// <summary>
        /// Виртуальный метод f = f1
        /// </summary>
        /// <param name="x">Аргумент функции</param>
        /// <returns>Квадрат числа x</returns>
        public virtual double f(double x)
        {
            return x * x;
        }
    }

    /// <summary>
    /// Производный класс, содержащий переопределяемый метод f
    /// </summary>
    public class DerivedFunction : BaseFunction
    {
        /// <summary>
        /// Переопределённый метод f = f2
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Инкрементированное число x</returns>
        public override double f(double x)
        {
            return x + 1;
        }
    }
}