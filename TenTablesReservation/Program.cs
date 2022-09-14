/*
* Requeriments of this program:
* 1. Validate is user is registered or if he must register
* 2. Welcome at the user if he exists
* 3. Repeat the program up to register ten users
*/
using System;

namespace TenTablesReservation
{
    class Program
    {
        
        
        public bool Auth(string enterUser,string[] users)
        {
            // for(int i=0; i<users.Length; i++)
            // {
            //     if(users[i]==enterUser || users[i]==enterUser.ToLower())
            //     {
            //         Console.WriteLine("Welcome {0}, you have reserved a table now",enterUser);
            //         return true;
            //     }
            // }
            //This is other way to verify element enterUser is in array users. Doesn't require FOR cycle
            int index=Array.IndexOf(users,enterUser);
            int index2=Array.IndexOf(users,enterUser.ToLower());
            if(index2!=-1 && index!=-1)
            {
                Console.WriteLine("Welcome {0}, you have reserved a table now",enterUser);
                return true;
            }
            Console.WriteLine("User is not registered");
            return false;
        } 
            
        public int CountTables(bool auth)
        {
            if(auth==true)
            {
                return 1;
            }else{
                return 0;
            }
            
        }

        public List<string> UserList(List<string> userReserved, bool auth, string user)
        {
            userReserved = userReserved;   
            if(auth==true)
            {
                userReserved.Add(user);
            }
            return userReserved;
        }

        static void Main(String[] args)
        {
            string[] users;
            users=new string[] {"paco","lucas","juancho","lalo","lula","amy","mara","rafa","lucre","mimi"};
            List<string> userReserved=new List<string>();
            int reservedTables=0;
            bool successAuth;

            while (reservedTables<11)
            {
                Program program = new Program();
                Console.WriteLine("Please enter your username");
                string enterUser=Console.ReadLine();
                successAuth=program.Auth(enterUser,users); //TODO: Validate and add table reserved is possible in a only instruction
                userReserved=program.UserList(userReserved,successAuth,enterUser);
                reservedTables+=program.CountTables(successAuth);

            }
            Console.WriteLine("Ten tables reserved. Try again tomorrow");
            Console.WriteLine("The users with reservations are: ");
            for (int i=0;i<userReserved.Count;i++)
                Console.WriteLine("* {0}",userReserved[i]);
            Environment.Exit(0);

        }
    }
}