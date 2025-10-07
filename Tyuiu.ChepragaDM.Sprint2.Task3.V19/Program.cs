using Tyuiu.ChepragaDM.Sprint2.Task3.V19.Lib;
namespace Tyuiu.ChepragaDM.Sprint2.Task3.V19
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
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
        Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
        Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
        Console.WriteLine("* трех знаков после запятой                                               *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");



        double x;

        Console.WriteLine("Введите значение переменной X: ");
        x = Convert.ToDouble(Console.ReadLine());


        


        double res = ds.Calculate(x);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);


        Console.ReadKey();
    }
}
}