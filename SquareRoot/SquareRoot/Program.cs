//3.Qəbul etdiyi integer parametrə həmin parametrin dəyərinin ən yaxın kökaltı dəyərini mənimsədən metod
//misal üçün, int num = 35 variable-mız var.Bu variable-ı həmin metoda göndərdikdə variable-ın dəyəri 5 olmalıdır.


using System;

namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 35;

            Sqrt(ref number);

            Console.WriteLine(number);
        }

        static int Sqrt(ref int num)
        {
            int count = 0;
            for(int i=1; i*i<=num; i++)
            {
                count++;
            }

            num = count;

            return num;
        }
    }
}
