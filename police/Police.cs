using System;
using System.Collections.Generic;
using System.Text;

namespace police
{
    class Police: Person
    {
        public int Password;

        public Police()
        {

        }
        public Police(string id, string firsname, string lastname, int password)
        {
            ID = id;
            Firsname = firsname;
            Lastname = lastname;
            Password = password;
        }

        //public void print()
        //{
        //    Console.WriteLine("full name: {0} {1}, ID:{2}, password: {3}", Firsname, Lastname, ID, Password);
        //}
        public override string ToString()
        {
            return base.ToString() + ", password: " + Password;
        }

        public static bool LoginID(Person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Police temp = arr[i] as Police;
                if (temp != null && arr[i].ID == user)
                    return true;
            }
            return false;
        }
        public static bool LoginPassword(Person[] arr, int intuser, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Police temp = arr[i] as Police;
                if (temp != null && temp.ID == user && temp.Password == intuser)
                    return true;
            }
            return false;
        }


    }
}
