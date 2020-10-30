using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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
                        Console.WriteLine("60세 이상인 사람 2명을 검색 (group-by 사용)"); 
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
                                        void Print() => Console.WriteLine(p.SSN + "," + p.Name + "," + p.Address + "," + p.Age);
                                        Print();
                                        i++;
                                    }
                                }
                        } i = 0;
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
                                    Console.WriteLine(p.SSN + "," + p.Name + "," + p.Address + "," + p.Age);
                                }
                        }
                        break;
                    case 3: 
                        Console.WriteLine("모두 나이가 10 세이상인지 체크하고 그 결과 출력");
                        var third = from correctPerson in listPersonsInCity
                                    select correctPerson.Age >= 10;
                        if(third.ToList().Count == listPersonsInCity.Count)
                            Console.WriteLine("모두 나이가 10세 이상입니다.");
                        break;
                    case 4: 
                        Console.WriteLine("모든 사람을 대상으로 평균 연령 구하기(Average 표준연산자 사용)");
                        var d = from correctPerson in listPersonsInCity
                                select correctPerson.Age;
                        Action ActAve = () => Console.WriteLine("평균 연령은 " + d.Average() + "세 입니다");
                        ActAve();
                        break;
                    case 5: 
                        Console.WriteLine("SAM 이란 이름을 검색 하고 삭제하기");
                        var e = from correctPerson in listPersonsInCity
                                where !correctPerson.Name.Contains("SAM")
                                select correctPerson;
                        listPersonsInCity = e.ToList();
                        Console.WriteLine("SAM이 들어간 이름의 데이터가 삭제 되었습니다.");
                        break;
                    case 6: 
                        Console.WriteLine("Smith 인덱스 위치 알아내기");
                        var f = from correctPerson in listPersonsInCity
                                where correctPerson.Name.Contains("Smith")
                                select correctPerson;

                        var arr = f.ToArray<Person>()[0];
                        int count = 0;
                        foreach (Person p in listPersonsInCity)
                        {
                            if (p.Equals(arr)) break;
                            count++;
                        }
                        Action PrintInx = () => Console.WriteLine("Smith의 인덱스 위치는 "+ count + "입니다.");
                        PrintInx();
                        break;
                    case 7: 
                        Console.WriteLine("나이가 가장 많은 사람의 이름과 나이 출력");
                        var g = from correctPerson in listPersonsInCity
                                group correctPerson by correctPerson.Age > 0 into a
                                select new
                                {
                                    Max = a.Max(correctPerson => correctPerson.Age)
                                };
                        foreach(var stat in g)
                        {
                            foreach(var person in listPersonsInCity)
                            {
                                if(person.Age == stat.Max)
                                {
                                    Console.Write("가장 나이가 많은 사람의 이름은 " + person.Name + "이고, ");
                                    Console.WriteLine("그 사람의 나이는 " + person.Age + "입니다.");
                                }
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine("모든 사람의 나이 합 출력(Sum 표준연산자 사용)");
                        var h = from correctPerson in listPersonsInCity
                                select correctPerson.Age;
                        Action PrintSum = () => Console.WriteLine("모든 사람의 나이의 합은 " + h.Sum() + "세 입니다");
                        PrintSum();
                        break;
                    case 9:
                        Console.WriteLine("60세 이상인 사람 리스트(group-by 사용)");
                        var I = from correctPerson in listPersonsInCity
                                group correctPerson by correctPerson.Age >= 60 into a
                                select new
                                {
                                    GroupKey = a.Key, correctPerson = a
                                };
                        foreach (var Group in I)
                        {
                            if (Group.GroupKey)
                            {
                                foreach (var person in Group.correctPerson)
                                {
                                    Console.WriteLine("이름 - "+person.Name + ", 나이 - " + person.Age);
                                }
                            }
                        }
                        break;
                    case 10:
                        Console.WriteLine("이름이 J로 시작하는 사람 찾기 (Contain 표준연산자 사용)");
                        var j = from correctPerson in listPersonsInCity
                                where correctPerson.Name.Contains("J")
                                select correctPerson;
                        List<Person> jPerson = j.ToList();
                        Action PrintStartJ = () => Console.WriteLine("이름이 J로 시작하는 사람은 "+jPerson[0].Age+"세 "+ jPerson[0].Name + "입니다.");
                        PrintStartJ();
                        break;
                    case 11:
                        Console.WriteLine("모든 사람이 SSN을 가지고 있는지 확인");
                        var k = from correctPerson in listPersonsInCity
                                where correctPerson.SSN.Length==0
                                select correctPerson;
                        List<Person> kPerson = k.ToList();
                        Action PrintSol = () =>
                        {
                            if (kPerson.Count == 0)
                                Console.WriteLine("모든 사람이 SSN을 가지고 있습니다.");
                        };
                        PrintSol();
                        break;
                    case 12:
                        Console.WriteLine("SSN코드 203456876 검색");
                        var L = from correctPerson in listPersonsInCity
                                where correctPerson.SSN.Equals("203456876")
                                select correctPerson;
                        List<Person> LPerson = L.ToList();
                        Action PrintSSNCode = () => Console.WriteLine("SSN코드 203456876인 사람은 " + LPerson[0].Age + "세 " + LPerson[0].Name + "입니다.");
                        PrintSSNCode();
                        break;
                    default:
                        return;
                }
                
            }
        }
    }
}
