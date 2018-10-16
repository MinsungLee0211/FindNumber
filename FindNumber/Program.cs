using System;

namespace FindNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rn = new Random();
            int randomNumber = rn.Next(0,100);

            int inputNumber;

            int max = 100;
            int min = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("숫자를 입력하세요. 범위 : " +  min + "이상 " + max + "이하 " + (10 - i) + "번 남음");

                for (; ; )
                {
                    if (Int32.TryParse(Console.ReadLine(), out inputNumber) && inputNumber > min && inputNumber < max)
                    {
                        break;
                    }
                }
                if (inputNumber == randomNumber)
                {
                    Console.WriteLine("숫자를 찾으셨습니다.");
                    break;
                }
                else if (inputNumber > randomNumber)
                {
                    max = inputNumber;
                }
                else if (inputNumber < randomNumber)
                {
                    min = inputNumber;
                }
            }
            Console.ReadKey();
        }
    }
}
