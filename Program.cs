namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            //1
            Console.WriteLine("int num 1-100");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 100)
                {
                    if (num % 3 == 0 && num % 5 == 0)
                        Console.WriteLine("Fizz Buzz");
                    else if (num % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (num % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(num);
                }
            //2
            Console.WriteLine("input num");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input percent");
            int percent = Convert.ToInt32(Console.ReadLine());

            int result = (value * percent) / 100;
            Console.WriteLine($"{percent}% from {value} = {result}");
            //3
            Console.WriteLine("input 4 nums");

            int digit1 = Convert.ToInt32(Console.ReadLine());
            int digit2 = Convert.ToInt32(Console.ReadLine());
            int digit3 = Convert.ToInt32(Console.ReadLine());
            int digit4 = Convert.ToInt32(Console.ReadLine());

            int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
            Console.WriteLine($"number: {number}");
            //6
            Console.WriteLine("select");
            Console.WriteLine("1 f -> c");
            Console.WriteLine("2 c->");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter temperature:");
            int temp = Convert.ToInt32(Console.ReadLine());
            int result2;

            if (choice == 1)
            {
                result2 = (temp - 32) * 5 / 9;
                Console.WriteLine($"result: {result2} °C");
            }
            else if (choice == 2)
            {
                result2 = (temp * 9 / 5) + 32;
                Console.WriteLine($"result: {result2} °F");
            }
            //8
            Console.WriteLine("enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Перетворюємо число в рядок, щоб визначити кількість цифр
            string numStr = num1.ToString();
            int numDigits = numStr.Length;

            int sum = 0;
            int tempNum = num1;

            // Обчислюємо суму цифр, піднесених до степеня кількості цифр
            while (tempNum > 0)
            {
                int digit = tempNum % 10;  // Отримуємо останню цифру
                sum += (int)Math.Pow(digit, numDigits);  // Підносимо цифру до степеня
                tempNum /= 10;  // Відкидаємо останню цифру
            }

            // Перевірка на число Армстронга
            if (sum == num1)
            {
                Console.WriteLine($"{num1} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{num1} is not an Armstrong number.");
            }
        }
    }
}



