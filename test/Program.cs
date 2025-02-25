using System;

namespace test
{
    class Program
    {
        static int chetn(int left, int right)
        {
            int sum = 0;
            for (int number = left; number <= right; number++)
            {

                int tmp = Math.Abs(number);
                while (tmp > 0)
                {
                    if (tmp % 2 == 0)
                        sum += tmp % 10;
                    tmp /= 10;
                }
            }



            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sum;
            sum = chetn(0, 100);
            Console.WriteLine(sum);
            DateTime data = new DateTime(2003, 4, 11);
            Person person1 = new Person(110, 65, data, "Имя Фамилия");
            Person person2 = new Person(100, 56, data, "Иван Иванов");
        }
    }
}
