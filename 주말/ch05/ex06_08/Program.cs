using System;
using System.Collections.Generic;

namespace ex06_08
{
    class SNS
    {
        static int userCount;

        class User
        {
            int userCode;
            string name;

            List<User> friends = new List<User>();
            List<Post> posts = new List<Post>();
        }
        class Post
        {
            string writer;
            string date;
            string content;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
