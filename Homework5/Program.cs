using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5
{
    class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public Person(string ssn, string name, string addr, int age)
        {
            SSN = ssn;
            Name = name;
            Address = addr;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
            listPersonsInCity.Add(new Person("203456877", "SAM", "13 Main Street, Newyork, NY", 25));
            listPersonsInCity.Add(new Person(" 203456878", " Elan", "14 Main Street, Newyork, NY", 35)); 
            listPersonsInCity.Add(new Person(" 203456879", " Smith", "12 Main Street, Newyork, NY", 45));
            listPersonsInCity.Add(new Person(" 203456880", " SAM", "345 Main Ave, Dayton, OH", 55));
            listPersonsInCity.Add(new Person(" 203456881", " Sue", "32 Cranbrook Rd, Newyork, NY", 65));
            listPersonsInCity.Add(new Person(" 203456882", " Winston", "1208 Alex St, Newyork, NY", 65));
            listPersonsInCity.Add(new Person(" 203456883", " Mac", "126 Province Ave, Baltimore, NY", 85));

            int i = 0;
            while (true)
            {
                Console.Write("조건 번호를 입력하세요. ");
                string s = Console.ReadLine();
                int flag = Convert.ToInt32(s);

                switch (flag)
                {
                    case 1:
                        Console.WriteLine("60세 이상인 사람 2명을 검색 (group-by 사용)"); // 2명 미완
                        var first = from correctPerson in listPersonsInCity
                                    group correctPerson by correctPerson.Age > 60 into cp
                                    select new
                                    {
                                        Key = cp.Key,
                                        human = cp
                                    };
                        foreach(var person in first)
                        {
                            if (person.Key)
                                foreach(var p in person.human)
                                {
                                    if (i< 2)
                                    {
                                        Console.WriteLine(p.SSN + "," + p.Name + "," + p.Address + "," + p.Age);
                                        i++;
                                    }
                                }
                        }
                        break;
                    case 2:
                        Console.WriteLine("13~19세 사이인 청소년을 리스트에서 검색 (group-by 사용)");
                        var second = from correctPerson in listPersonsInCity
                                    group correctPerson by correctPerson.Age >= 13 && correctPerson.Age <= 19 into cp
                                    select new
                                    {
                                        Key = cp.Key,
                                        human = cp
                                    };
                        foreach (var person in second)
                        {
                            if (person.Key)
                                foreach (var p in person.human)
                                {
                                    if (i < 2)
                                    {
                                        Console.WriteLine(p.SSN + "," + p.Name + "," + p.Address + "," + p.Age);
                                        i++;
                                    }
                                }
                        }
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    default:
                        return;
                }
                
            }
        }
    }
}
