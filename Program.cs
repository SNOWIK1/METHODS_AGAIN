using System;

namespace Methods_again
{
    class Program
    {
        static int findIndex(int[] arr, int size, int num)
        {
            int res = 0;

            for (int i= 0; i<size; i++)
            {
                
                if(arr[i] == num)
                {
                    return res = arr[i-1];
                } 
               
            }
            
            return -1;
        }


        static void fillRand(int[] arr, int start, int end)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(start, end + 1);
            }
        }



        static int reverse(int x)
        {
            int reversed = 0;
            while (x !=0)
            {
                int digit = x % 10;
                reversed= reversed * 10 + digit;
                x /= 10;
            }
            return reversed;

        }


        static void revStr(string str)
        {
            string[] splitted = str.Split(" ");
            Array.Reverse(splitted);
            string joined = string.Join(" ", splitted);
            Console.WriteLine(joined);
        }

        static void avg (string arr)
        {
            int sum = 0;
            string[] newArr = arr.Split(" ");

            for(int i= 0; i< newArr.Length; i++)
            {
               
                sum += int.Parse(newArr[i]);
            }
            Console.WriteLine(sum/ newArr.Length);
        }



        static bool isPrime(int number)
        {
            if(number < 2)
            {
                return false;
            }
            for(int i = 2; i<number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }




        static void findPrime(int start, int end)
        {
            for (int i = start; i<end; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nTASK 1. Enter the start point: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end point: ");
            int end = int.Parse(Console.ReadLine());
            findPrime(start, end);

              Console.WriteLine("\nTASK 2. Enter any number: ");
              string enter = Console.ReadLine();
              Console.WriteLine(reverse(int.Parse(enter)));

              Console.WriteLine("\nTASK 3. Enter any numbers to calculate average value: ");
              string numbers = Console.ReadLine();
              avg(numbers);
            Console.WriteLine("\nTASK 4. Write any words here: ");
            string str = Console.ReadLine();
            Console.WriteLine("Reversed string: ");
            revStr(str);

            Console.WriteLine("\nTASK 5. Enter a start bound of random numbers: ");
            int strtp = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter an end bound of random numbers: ");
            int endp = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter a size of an array (use intteger only): ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            fillRand(array, strtp, endp);

            Console.WriteLine("\nThe random array:");

            foreach (int item in array)
            {
                Console.Write( item );
            }

            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine("\nTASK 6Index of this number: ");
            Console.WriteLine(findIndex(arr, arr.Length, 2));



        }
    }
     

}
