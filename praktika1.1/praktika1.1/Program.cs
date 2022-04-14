using System;

namespace praktika1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library a = new Library();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 - Добавить библиотеку" + " " +
                "2 - Вывести библиотеку" + " " + "3 - Выход");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            a.Input();
                            break;
                        }
                    case 2:
                        {
                            a.Print();
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            }
        }
    }
}
