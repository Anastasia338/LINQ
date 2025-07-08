
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] cities = {"Athens", "Albany","Newark", "Naperville","Nuremberg", "Memphis","Plymouth", "Krakow", "Aberdeen",   
//            "Brighton",   
//            "Durban"      
//        };

//        var allCities = from c in cities select c;
//        Console.WriteLine("Все города:");
//        PrintCollection(allCities);

//        int length = 7;
//        var citiesWithLength = from c in cities
//                               where c.Length == length
//                               select c;
//        Console.WriteLine($"\nГорода с длиной названия {length}:");
//        PrintCollection(citiesWithLength);


//        var startsWithA = from c in cities
//                          where c.StartsWith("A", StringComparison.OrdinalIgnoreCase)
//                          select c;
//        Console.WriteLine("\nГорода, начинающиеся с буквы A:");
//        PrintCollection(startsWithA);

//        var endsWithM = from c in cities
//                        where c.EndsWith("m", StringComparison.OrdinalIgnoreCase)
//                        select c;
//        Console.WriteLine("\nГорода, заканчивающиеся на букву M:");
//        PrintCollection(endsWithM);

//        var startsNendsK = from c in cities
//                           where c.StartsWith("N", StringComparison.OrdinalIgnoreCase)
//                           && c.EndsWith("k", StringComparison.OrdinalIgnoreCase)
//                           select c;
//        Console.WriteLine("\nГорода, начинающиеся на N и заканчивающиеся на K:");
//        PrintCollection(startsNendsK);

       
//        var startsNeDesc = from c in cities
//                           where c.StartsWith("Ne", StringComparison.OrdinalIgnoreCase)
//                           orderby c descending
//                           select c;
//        Console.WriteLine("\nГорода, начинающиеся на Ne (по убыванию):");
//        PrintCollection(startsNeDesc);
//    }

//    static void PrintCollection<T>(IEnumerable<T> collection)
//    {
//        foreach (var item in collection)
//            Console.WriteLine(item);
//    }
//}
