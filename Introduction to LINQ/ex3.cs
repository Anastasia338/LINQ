//using System;
//using System.Linq;

//class Program
//{
//    public class Student
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int Age { get; set; }
//        public string Institution { get; set; }

//        public override string ToString()
//        {
//            return $"{FirstName} {LastName}, Age: {Age}, Institution: {Institution}";
//        }
//    }

//    static void Main()
//    {
//        Student[] students = {
//            new Student { FirstName = "Benjamin", LastName = "Brown", Age = 22, Institution = "MIT" },
//            new Student { FirstName = "Alice", LastName = "Brooks", Age = 20, Institution = "Oxford" },
//            new Student { FirstName = "Benjamin", LastName = "Black", Age = 18, Institution = "Harvard" },
//            new Student { FirstName = "Jack", LastName = "Doe", Age = 21, Institution = "Oxford" },
//            new Student { FirstName = "Evelyn", LastName = "Brooks", Age = 19, Institution = "MIT" },
//            new Student { FirstName = "Mark", LastName = "Brown", Age = 24, Institution = "Cambridge" },
//            new Student { FirstName = "Sophia", LastName = "Bro", Age = 23, Institution = "Oxford" }
//        };

//        var allStudents = from s in students select s;
//        Console.WriteLine("Все студенты:");
//        PrintCollection(allStudents);

   
//        var namedBenjamin = from s in students
//                            where s.FirstName == "Benjamin"
//                            select s;
//        Console.WriteLine("\nСтуденты с именем Benjamin:");
//        PrintCollection(namedBenjamin);

//        var lastNameBro = from s in students
//                          where s.LastName.StartsWith("Bro")
//                          select s;
//        Console.WriteLine("\nСтуденты с фамилией, начинающейся на 'Bro':");
//        PrintCollection(lastNameBro);

  
//        var olderThan19 = from s in students
//                          where s.Age > 19
//                          select s;
//        Console.WriteLine("\nСтуденты старше 19 лет:");
//        PrintCollection(olderThan19);

//        var between20and23 = from s in students
//                             where s.Age > 20 && s.Age < 23
//                             select s;
//        Console.WriteLine("\nСтуденты старше 20 и младше 23:");
//        PrintCollection(between20and23);

//        var studyAtMIT = from s in students
//                         where s.Institution == "MIT"
//                         select s;
//        Console.WriteLine("\nСтуденты, обучающиеся в MIT:");
//        PrintCollection(studyAtMIT);

//        var oxfordOlder18 = from s in students
//                            where s.Institution == "Oxford" && s.Age > 18
//                            orderby s.Age descending
//                            select s;
//        Console.WriteLine("\nСтуденты из Oxford старше 18 (по убыванию возраста):");
//        PrintCollection(oxfordOlder18);
//    }

//    static void PrintCollection<T>(System.Collections.Generic.IEnumerable<T> collection)
//    {
//        foreach (var item in collection)
//            Console.WriteLine(item);
//    }
//}
