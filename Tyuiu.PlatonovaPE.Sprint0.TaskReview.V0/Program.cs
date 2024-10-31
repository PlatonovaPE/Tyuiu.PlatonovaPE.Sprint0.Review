using Tyuiu.PlatonovaPE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PlatonovaPE.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, A;

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Z:");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение A:");
            A = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(ds.Calculate(x, y, z, A));
            Console.ReadKey();

        }
    }
}
