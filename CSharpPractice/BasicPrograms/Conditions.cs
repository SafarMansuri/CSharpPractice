namespace CSharpPractice.BasicPrograms
{
    internal class Conditions
    {
        public void Checkage(int a) {
            if (a < 18)
                Console.WriteLine("you ara a minor");
            else
                Console.WriteLine("you ara an adult");
        }
        public void printLargestNumber(int a, int b, int c) {
            if (a > b && a > c)
            {
                Console.WriteLine("Number 1 is big", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Number 2 is big", b);
            }
            else {
                Console.WriteLine("Number 3 is big",c);
            }
        }

        public void CheckOddEven(int number) {
            if (number % 2 == 0) {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

        }
        public void calculator(int number, int number2, string symbol) {

            switch (symbol){

                case "+":
                     Console.WriteLine($"Result is {number + number2}");
                     break;
                case "-":
                    Console.WriteLine($"Result is {number - number2}");
                    break;
                case "*":
                    Console.WriteLine($"Result is {number * number2}");
                    break;
                case "/":
                    if (number2 != 0)
                        Console.WriteLine($"Result is {number / number2}");
                    else 
                        Console.WriteLine("can't diveide by zero");
                    break;
                default:
                    Console.WriteLine($"Invalid oprator");
                    break;
            }
           
        }
        public void PrintRange(int number) {

            for (int i = 1; i <= number; i++) {
                if (i % 5 == 0)
                    continue;     
               Console.WriteLine(i + "");
            }
        }

        public void sumofNNumbers(int number) {
            int sum = 0;

            for (int i = 1; i <= number; i++) { 
               sum = sum + i;
            }
            Console.WriteLine("sum is " + sum);
        }
        public void PrintTable(int num) {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($" {num} * {i} = {num * i}");
            }
        }
        public void factorialOfGivennumber(int number)
        {
            int sum = 1;

            for (int i = 1; i <= number; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("factorial is " + sum);
        }
        public void GuesstheNumber() { 
          Random random = new Random();
            int secretnumber = random.Next(1,100);
            int guess = 0;

            Console.WriteLine("Welcome to Guess the number game");
            Console.WriteLine("Guess the number beetween 1 to 100");

            while (secretnumber != guess) {

                Console.WriteLine("Enter your Guess");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < secretnumber)
                    Console.WriteLine("Too low! try again");
                else if (guess > secretnumber)
                    Console.WriteLine("Too high! try again");
                else Console.WriteLine($"perfect the number was {secretnumber}");
            }
        }
    }
}
