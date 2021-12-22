using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Lab11
{

    class Program
    {
        static void Main(string[] args)
        {
            // ***************************** Task 1 *******************************
            var months = new[]
        {
                    "June",
                    "July",
                    "August",
                    "December",
                    "January",
                    "February",
                    "March",
                    "April",
                    "May",
                    "September",
                    "October",
                    "November"
                };

            var summerMonths = new[]
        {
                    "June",
                    "July",
                    "August"
                };

            var winterMonths = new[]
        {
                    "December",
                    "January",
                    "February"
                };

            Console.Write("Enter month name length: ");
            int nameLength = Utils.ScanIntValue();

            string[] nameLengthQueryResult = months.Where(x => x.Length == nameLength).ToArray();

            Console.WriteLine($"Months with name length {nameLength}:");
            Console.WriteLine(Utils.FormatCollection(nameLengthQueryResult));

            Console.WriteLine();

            // Where winter or summer months
            Console.WriteLine("Winter and summer months:");

            string[] winterSummerQueryResult = months
                .Where(x =>
                    summerMonths.Contains(x)
                    || winterMonths.Contains(x))
                .ToArray();

            Console.WriteLine(Utils.FormatCollection(winterSummerQueryResult));

            Console.WriteLine();

            // Alphabet order
            Console.WriteLine("Alphabet order months:");

            string[] alphabetOrderResult = months
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(Utils.FormatCollection(alphabetOrderResult));

            Console.WriteLine();

            // Custom condition
            Console.WriteLine("Custom query months:");

            string[] customQueryResult = months
                .Where(x => x.Contains('u')
                    && x.Length >= 4)
                .ToArray();

            Console.WriteLine(Utils.FormatCollection(customQueryResult));

            //************************Task 2***************************

            Student styd1 = new Student("Cola", "Poit", 2, 16);
            Student styd2 = new Student("Comrad", "Poit", 2, 19);
            Student styd3 = new Student("Jim", "Isit", 8, 21);
            Student styd4= new Student("Oumay", "Mobilki", 4, 19);
            Student styd5 = new Student("Comrad", "Deivi", 10, 18);
            Student styd6 = new Student("Colm", "Poit", 1, 17);

            List<Student> liststud = new List<Student>() { styd1, styd2, styd3, styd4, styd5, styd6 };
            foreach (Student b in liststud)
                Console.WriteLine(b.ToString());    /// через ToString выводится информация об объекте в консось
            Console.WriteLine();


            Console.WriteLine("*****************Список заданной специальности*******************");
            var specstud = from b in liststud
                           where b.Special == "Poit"
                           select b;
            foreach (Student b in specstud)
                Console.WriteLine(b.ToString() + "Имя " + b.FirstName);
            Console.WriteLine();

            Console.WriteLine("*****************Список заданной группы*******************");
            var groupstud = from b in liststud
                           where b.Group == 2
                           select b;
            foreach (Student b in groupstud)
                Console.WriteLine(b.ToString() + "Имя " + b.FirstName);
            Console.WriteLine();

            Console.WriteLine("*****************Самый молодой студент*******************");
            var min = liststud.Min(b => b.Age);
            var minyear = liststud.FirstOrDefault(b => b.Age == min);
            Console.WriteLine(minyear + " - возраст самого молодого студента" );
            Console.WriteLine();
            Console.WriteLine("*****************Кол-во студентов заданной группы упоряд по фамилии*******************");
           
           
            var sortstud = from b in liststud
                           where b.Special == "Poit"
                           orderby b.FirstName
                           select b;
            foreach (Student b in sortstud)
                Console.WriteLine(b + " Имя " + b.FirstName);
            Console.WriteLine();

            Console.WriteLine("***************Первый студент с заданным именем*********************");
            var firstdtud = liststud.First(b => b.FirstName == "Comrad");
            Console.WriteLine(firstdtud + " Первый студент с нужным именем");
            Console.WriteLine();

            Console.WriteLine("**********************Люди с определенной страны****************");
            
             List<IDK> cont = new List<IDK>() {
             new IDK ("Cola", "Belarus"),
             new IDK ("Comrad", "China")
             };
           

            var result = from b in liststud
                         join t in cont on b.FirstName equals t.FirstName
                         select new { FirstName = t.FirstName, Country = t.Country };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FirstName} - {item.Country}");
            }
            
        }





        



        public static class Utils
            {
                public static int ScanIntValue()
                {
                    int result;
                    var success = false;

                    do
                    {
                        string input = Console.ReadLine();

                        success = int.TryParse(input, out result);
                    } while (!success);

                    return result;
                }

                public static string ScanStringValue()

                {
                    string result = null;
                    var success = false;

                    do
                    {
                        string input = Console.ReadLine();

                        success = !string.IsNullOrWhiteSpace(input);
                        result = input;
                    } while (!success);

                    return result;
                }

                public static string FormatCollection(IEnumerable<string> collection)
                {
                    return string.Join(",", collection);
                }
            }
            

           
        

    }
}
