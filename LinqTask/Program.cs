using System;
using System.Collections.Generic;

namespace LinqTask
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic logic = new BusinessLogic();
            Console.WriteLine("-----Работа метода GetUsersBySurname(Ivanov)-----");
            foreach (var u in logic.GetUsersBySurname("Ivanov")) Console.WriteLine(u);
            Console.WriteLine("-----Работа метода GetUsersBySurname(Olegov)-----");
            foreach (var u in logic.GetUsersBySurname("Olegov")) Console.WriteLine(u);
            Console.WriteLine("-----Работа метода GetUsersByID(1000)-----");
            Console.WriteLine(logic.GetUserByID(1000));
            Console.WriteLine("-----Работа метода GetUsersByID(10)-----");
            Console.WriteLine(logic.GetUserByID(10));
            Console.WriteLine("-----Работа метода GetUsersBySubstring(ov)-----");
            foreach (var u in logic.GetUsersBySubstring("ov")) Console.WriteLine(u);
            Console.WriteLine("-----Работа метода GetUsersBySubstring(abc)-----");
            foreach (var u in logic.GetUsersBySubstring("abc")) Console.WriteLine(u);
            Console.WriteLine("-----Работа метода GetAllUniqueNames()-----");
            foreach (string s in logic.GetAllUniqueNames()) Console.WriteLine(s);
            Console.WriteLine("-----Работа метода GetAllAuthors()-----");
            foreach (var a in logic.GetAllAuthors()) Console.WriteLine(a);
            Console.WriteLine("-----Работа метода GetUsersDictionary()-----");
            foreach (var v in logic.GetUsersDictionary()) Console.WriteLine($"{v.Value}");
            Console.WriteLine("-----Работа метода GetMaxID()-----");
            Console.WriteLine(logic.GetMaxID());
            Console.WriteLine("-----Работа метода GetOrderedUsers()-----");
            foreach (var u in logic.GetOrderedUsers()) Console.WriteLine(u);
            Console.WriteLine("-----Работа метода GetDescendingOrderedUsers()-----");
            foreach (var u in logic.GetDescendingOrderedUsers()) Console.WriteLine(u);
            Console.WriteLine("-----Работа метода GetReversedUsers()-----");
            foreach (var u in logic.GetReversedUsers()) Console.WriteLine(u);
            Console.WriteLine("-----Работа метода GetUsersPage(2, 2)-----");
            foreach (var u in logic.GetUsersPage(2, 2)) Console.WriteLine(u);
        }
       
    }
}
