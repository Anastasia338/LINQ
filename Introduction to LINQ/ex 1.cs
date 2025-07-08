//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 10, 21, 14, 7, 56, 8, 63, 49, 64, 28, 16 };

//        var allNumbers = from n in numbers select n;
//        Console.WriteLine("Весь массив:");
//       PrintCollection(allNumbers);

//        var evenNumbers = from n in numbers
//                          where n % 2 == 0
//                          select n;
//        Console.WriteLine("Четные числа:");
//        PrintCollection(evenNumbers);

//        var oddNumbers = from n in numbers
//                         where n % 2 != 0
//                         select n;
//        Console.WriteLine("Нечетные числа:");
//        PrintCollection(oddNumbers);

//        int threshold = 20;
//        var greaterThan = from n in numbers
//                          where n > threshold
//                          select n;
//        Console.WriteLine($"Числа больше {threshold}:");
//        PrintCollection(greaterThan);

//        int minRange = 15;
//        int maxRange = 50;
//        var inRange = from n in numbers
//                      where n >= minRange && n <= maxRange
//                      select n;
//        Console.WriteLine($"Числа в диапазоне от {minRange} до {maxRange}:");
//        PrintCollection(inRange);

//        var multiplesOf7 = from n in numbers
//                           where n % 7 == 0
//                           orderby n ascending
//                           select n;
//        Console.WriteLine("Числа, кратные 7 (по возрастанию):");
//        PrintCollection(multiplesOf7);

//        var multiplesOf8 = from n in numbers
//                           where n % 8 == 0
//                           orderby n descending
//                           select n;
//        Console.WriteLine("Числа, кратные 8 (по убыванию):");
//        PrintCollection(multiplesOf8);
//    }

//    static void PrintCollection<T>(IEnumerable<T> collection)
//    {
//        foreach (var item in collection)
//            Console.Write(item + " ");
//        Console.WriteLine();
//    }
//}
