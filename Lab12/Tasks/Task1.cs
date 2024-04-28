namespace Lab12
{
    class Task1
    {
        public static void Tas1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var allNumbers = numbers;

            // парні
            var evenNumbers = numbers.Where(num => num % 2 == 0);

            //непарні цілі
            var oddNumbers = numbers.Where(num => num % 2 != 0);

            //значення більше заданого.
            int threshold = 5;
            var numbersThreshold = numbers.Where(num => num > threshold);

            //числа в заданому діапазоні.
            int minRange = 3;
            int maxRange = 7;
            var numbersInRange = numbers.Where(num => num >= minRange && num <= maxRange);

            // кратні семи за зростанням.
            var numbersSeven = numbers.Where(num => num % 7 == 0).OrderBy(num => num);

            //кратні восьми за спаданням.
            var numbersEight = numbers.Where(num => num % 8 == 0).OrderByDescending(num => num);


            Console.WriteLine("The entire array of integers:");
            PrintResult(allNumbers);

            Console.WriteLine("\nEvenNumbers:");
            PrintResult(evenNumbers);

            Console.WriteLine("\nOdd Numbers:");
            PrintResult(oddNumbers);

            Console.WriteLine($"\nThe value is more {threshold}:");
            PrintResult(numbersThreshold);

            Console.WriteLine($"\nNumbers in the range from {minRange} to {maxRange}:");
            PrintResult(numbersInRange);

            Console.WriteLine("\n:Numbers in multiples of seven (ascending order)");
            PrintResult(numbersSeven);

            Console.WriteLine("\nNumbers that are multiples of eight (sorted in descending order):");
            PrintResult(numbersEight);

        }

        public static void PrintResult(IEnumerable<int> res)
        {
            foreach (var num in res)
            { 
                Console.WriteLine(num);
            }
        }

    }
}