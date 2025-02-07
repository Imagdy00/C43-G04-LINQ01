namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 1
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {

            //                var number = 10; 
            //                Console.WriteLine(number.GetType()); 


            //                dynamic value = "Hello";
            //                Console.WriteLine(value.GetType()); 

            //                value = 10; 
            //                Console.WriteLine(value.GetType()); 
            //            }
            //        }
            #endregion


            #region Video 2
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                var person = new { Name = "Ahmed", Age = 25 };
            //                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //            }
            //        }
            #endregion


            #region Video 3
            //            using System;

            //public static class StringExtensions
            //        {
            //            public static int WordCount(this string str)
            //            {
            //                return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                string sentence = "Hello, world!";
            //                Console.WriteLine(sentence.WordCount()); // Output: 2
            //            }
            //        }
            #endregion


            #region Video 4
            //            using System;
            //            using System.Linq;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                int[] numbers = { 1, 2, 3, 4, 5 };
            //                var evenNumbers = from num in numbers
            //                                  where num % 2 == 0
            //                                  select num;

            //                foreach (var num in evenNumbers)
            //                {
            //                    Console.WriteLine(num); // Output: 2, 4
            //                }
            //            }
            //        }
            #endregion

            #region Video 5
            //            using System;
            //            using System.Linq;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                string[] words = { "apple", "banana", "cherry", "date" };
            //                var sortedWords = from word in words
            //                                  orderby word.Length
            //                                  select word;

            //                foreach (var word in sortedWords)
            //                {
            //                    Console.WriteLine(word); // Output: date, apple, cherry, banana
            //                }
            //            }
            //        }
            #endregion

            #region Video 6
            //            using System;
            //            using System.Linq;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                int[] numbers = { 1, 2, 3, 4, 5 };

            //                // Deferred Execution
            //                var evenNumbers = numbers.Where(n => n % 2 == 0);

            //                // Immediate Execution
            //                var evenNumbersList = evenNumbers.ToList();

            //                Console.WriteLine("Deferred Execution:");
            //                foreach (var num in evenNumbers)
            //                {
            //                    Console.WriteLine(num); // Output: 2, 4
            //                }

            //                Console.WriteLine("Immediate Execution:");
            //                foreach (var num in evenNumbersList)
            //                {
            //                    Console.WriteLine(num); // Output: 2, 4
            //                }
            //            }
            //        }
            #endregion

            #region Video 7
//            using System;
//            using System.Collections.Generic;

//class Program
//        {
//            static void Main()
//            {
//                var students = new List<Student>
//        {
//            new Student { Id = 1, Name = "Ahmed", Age = 20 },
//            new Student { Id = 2, Name = "Ali", Age = 22 },
//            new Student { Id = 3, Name = "Sara", Age = 21 }
//        };

//                var query = from student in students
//                            where student.Age > 20
//                            select student;

//                foreach (var student in query)
//                {
//                    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
//                }
//            }
//        }

//        class Student
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }
//            public int Age { get; set; }
//        }
        #endregion
    }
    }
}
