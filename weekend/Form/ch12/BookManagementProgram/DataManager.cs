using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookManagementProgram
{
    class DataManager
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        static DataManager()
        {
            Load();
        }

        private static void Load()
        {
            try
            {
                string booksOutput = File.ReadAllText(@"./Books.xml");
                XElement booksXElement = XElement.Parse(booksOutput);
                Books = (from item in booksXElement.Descendants("book") 
                         select new Book()
                    {
                        id = item.Element("id").Value,
                        name = item.Element("name").Value,
                        publisher = item.Element("publisher").Value,
                        page = int.Parse(item.Element("page").Value),
                        borrowedAt = DateTime.Parse(item.Element("borrowedAt").Value),
                        isBorrowed = item.Element("isBorrowed").Value != "0" ? true : false,
                        userId = int.Parse(item.Element("userId").Value),
                        userName = item.Element("userName").Value
                    }).ToList<Book>();


                string userOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(userOutput);
                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             id = int.Parse(item.Element("id").Value),
                             name = item.Element("name").Value
                         }).ToList<User>();
            }
            catch (FileNotFoundException e)
            {
                Save();
            }
        }

        private static void Save()
        {
            throw new NotImplementedException();
        }
    }
}
