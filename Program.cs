namespace DZ9;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(@"Выбери задачу
64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
q - выход из программы");



            string select = Console.ReadLine();
            switch (select)
            {
                case "64":
                    Console.WriteLine(Zad64(10));
                    break;
                case "66":
                    Console.WriteLine(Zad66(1, 5));
                    break;
                case "68":
                    Console.WriteLine(Zad68(3, 2));
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    /// </summary>
    /// <param name="N">Значение</param>
    /// <returns>Возвращает результат рекурсии</returns>
    static string Zad64(int N)
    {
        if (N == 1) return "1";
        return N + ", " + Zad64(N - 1);
        
    }

    /// <summary>
    /// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    /// </summary>
    /// <param name="M">Значение от</param>
    /// <param name="N">Значение до</param>
    /// <returns>Возвращает сумму элементов</returns>
    static int Zad66(int M, int N)
    {
        if (M > N) return 0;
        return M + Zad66(M + 1, N);
    }

    /// <summary>
    /// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    /// </summary>
    /// <param name="M">Неотрицательное число</param>
    /// <param name="N">Неотрицательное число</param>
    /// <returns>вычисления функции Аккермана с помощью рекурсии</returns>
    static int Zad68(int M, int N)
    {
        if (M == 0)
            return N + 1;
        else if (N == 0)
            return Zad68(M - 1, 1);
        else
            return Zad68(M - 1, Zad68(M, N - 1));
    }
}
