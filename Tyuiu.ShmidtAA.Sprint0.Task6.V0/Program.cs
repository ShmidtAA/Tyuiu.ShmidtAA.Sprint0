using Tyuiu.ShmidtAA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.ShmidtAA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            var arraynums= new int[] {1,2,3,4,5};

            Console.WriteLine("Сумма элементов массива " + DataService.AdditionArray(arraynums));

            Console.WriteLine("Разницы элементов массива " + DataService.SubtractionArray(arraynums));

            Console.WriteLine("Умножение элементов массива " + DataService.MultiplicationArray(arraynums));

            Console.ReadKey();
        }
    }
}
