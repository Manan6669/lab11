using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab11
{
    public class Student
    {
        string firstname;
        int studentAge;
        string Spec;
        public int group;
        string idk;
        public static short numberOfstudents = 0;

        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (!String.IsNullOrEmpty(firstname))
                    firstname = value;
            }
        }
       
        public int Age
        {
            get { return studentAge; }
            set
            {

            }
        }
        public string Special
        {
            get { return Spec; }
            set
            {
                if (!String.IsNullOrEmpty(Spec))
                    firstname = value;
            }
        }
        public int Group
        {
            get { return group; }
            set
            {

            }
        }
        public string Idk
        {
            get
            {
                return idk;
            }
            set { }
        }
        public Student()
        {
            firstname = "AAA";
            Group = 1;
            Age = 11;
            Special = "AAA";

            numberOfstudents++;
        }
        // Неполный конструктор
        public Student(string aName, string aSpec, int aGroup, short aAge)
        {
            firstname = aName;
            group = aGroup;
            studentAge = aAge;
            Spec = aSpec;
            
            numberOfstudents++;
        }
        public Student(string aName, string aSpec, int aGroup, short aAge,  string Idk)
        {
            firstname = aName;
            group = aGroup;
            idk = Idk;
            Spec = aSpec;

            numberOfstudents++;
        }
        public void PrintInfo()
        {
            Console.WriteLine("===========================================\n\tid: {0}\n\tИмя: {1}\n\tГруппа: {2}\n\t" +
                "Возраст: {3}\n\tСпециальность: {4}\n\t" +
                "===========================================",  firstname, group, studentAge, Spec, idk);
        }

        public static void TypeOfClass()
        {
            Type tp = Type.GetType("Lab11.Student");
            Console.WriteLine("\n\n  Тип класса Student:");
            Console.WriteLine(tp.AssemblyQualifiedName);
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
           Student b = obj as Student;
            if (b == null)
                return false;
            return this.firstname == b.firstname && this.group == b.group && this.Age == b.Age &&
            this.Special == b.Special && this.Idk == b.idk;
        }


        // Метод вывода строки
        public override string ToString()
        {
            return $"Имя: {FirstName}; Группа: {Group};  Возраст: {Age}; Специальность: {Special}";
        }

       
    }
 public class IDK
        {
            public string FirstName { get; set; }
            public string Country { get; set; }
           public IDK (string name, string country)
            {
                FirstName = name;
                Country = country;
            }
        }
   


}

