using Tyuiu.ChepragaDM.Sprint2.Task1.V11.Lib;
namespace Tyuiu.ChepragaDM.Sprint2.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
            Console.WriteLine("* (массив): (False, False, True, False, True, False)                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 145                                                                 *");
            Console.WriteLine("* b = 156                                                                 *");
            Console.WriteLine("* c = 142                                                                 *");
            Console.WriteLine("* d = 117                                                                 *");
            


            int a, b,c,d;
            a = 145;
            b = 156;
            c = 142;
            d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b,c,d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();
        }
    }
}
