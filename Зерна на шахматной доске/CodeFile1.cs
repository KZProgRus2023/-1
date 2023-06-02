/* пшеница */
#define SQUARES 64; /* число клеток на шахматной доске */
#define CROP 7E14; /* урожай пшеницы в США, выраженный в числе зерен */

using System;

namespace ZernaShahmDoska
{
    internal class Program
    {
        public static int SQUARES { get; private set; }
        public static double CROP { get; private set; }

        private static void Main(string[] args)
        {
            main();
                {
                double current, total;
                int count = 1;
                printf(" клетка число зерен сумма зерен доля\n");
                printf("от урожая в США\n");
        total = current = 1.0; /* начинаем с одного зерна */
                printf("%4d %15.2е %13.2е %12.2e\n", count, current, total, total
                    / CROP);
                while (count < SQUARES)
                {
                    count = count + 1;
                    current = 2.0 * current; /* у двоение числа зерен на следующей клетке*/
                    total = total + current; /* коррекция суммы */
                    printf(" %4d %15.2е %13.2е %12 2e\n", count, current, total, total / CROP);
                }
            }
        }

        private static void printf(string v)
        {
            throw new NotImplementedException();
        }

        private static void printf(string v, int count, double current, double total, double v1)
        {
            throw new NotImplementedException();
        }

        private static void main()
        {
            throw new NotImplementedException();
        }
    }
}