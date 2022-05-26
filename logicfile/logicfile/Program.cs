
namespace Logical_Programs
{
    class PrimeNumber
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check wheather its Prime or not ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                //checking the factors of a number by iterating from 1 to num.
                if (num % i == 0)
                    count++;
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is a Prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime number");
            }

        }

    }

}
