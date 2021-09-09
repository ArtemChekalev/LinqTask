using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinqTask
{
    class BusinessLogic
    {
        private List<User> users = new List<User>(); 
        private List<Record> records = new List<Record>(); 
        public BusinessLogic()
        {
            users.Add(new User(1000, "Anton", "Ivanov"));
            users.Add(new User(3441, "Oleg", "Olegov"));
            users.Add(new User(3515, "Vasiliy", "Vasiliev"));
            users.Add(new User(4753, "Anton", "Antonov"));
            users.Add(new User(3352, "Nikolay", "Nikolaev"));
            records.Add(new Record(users[1], "Hello!"));//сделать чуть более красиво через массивчики и енумерэйбл
        }
        public List<User> GetUsersBySurname(String surname)
        {
            var UsersBySurname = (from u in users where u.Surname == surname select u).ToList();
            return UsersBySurname;
        }

        public User GetUserByID(int id)
        {
            try
            {
                var UserByID = (from u in users where u.ID == id select u).Single();
                return UserByID;
            }
            catch (Exception)
            {
                Console.WriteLine("ID was not found");
                return null;
            }
        }
        public List<User> GetUsersBySubstring(String substring)
        {
            var UsersBySubstring = (from u in users where u.Name.Contains(substring) || u.Surname.Contains(substring) select u).ToList();
            return UsersBySubstring;
        }
        public List<String> GetAllUniqueNames()
        {
            var UniqueNames = (from u in users select u.Name).Distinct().ToList();
            return UniqueNames;
        }
        public List<User> GetAllAuthors()
        {
            var AllAuthors = (from r in records select r.Author).ToList();
            return AllAuthors;
        }
        public Dictionary<int, User> GetUsersDictionary()
        {
            Dictionary<int, User> UsersDictionsry = (from u in users select u).ToDictionary(u => u.ID, u => u);
            return UsersDictionsry;
        }
        public int GetMaxID()
        {
            var MaxID = (from u in users select u.ID).Max();
            return MaxID;
        }
        public List<User> GetOrderedUsers()
        {
            var OrderedUsers = (from u in users orderby u.ID select u).ToList();
            return OrderedUsers;
        }
        public List<User> GetDescendingOrderedUsers()
        {
            var DescendingOrderedUsers = (from u in users orderby u.ID descending select u).ToList();
            return DescendingOrderedUsers;
        }
        public List<User> GetReversedUsers()
        {
            var ReversedUsers = (from u in users select u).Reverse().ToList();
            return ReversedUsers;
        }
        public List<User> GetUsersPage(int pageSize, int pageIndex)
        {
            var UsersPage = (from u in users select u).Skip(pageSize-1).Take(pageIndex-1).ToList();
            return UsersPage;
        }

    }
}
