using System;

namespace police
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[53];
            for (int i = 0; i <49; i++)
            {
                person[i] = new Person();
                person[i].RandomString();
                person[i].RandomID();
                person[i].RandomIfPast();
                person[i].events();
                Console.WriteLine(person[i].ToString());
            }
            AddEvent(person);
            Console.WriteLine("-------------------------------------------");

            
            person[50] = new Police("203425881", "sharon", "bitton", 2332);
            person[51] = new Police("314471982", "lior", "avrham", 8912);
            person[52] = new Police("214587911", "matan", "danoh", 1188);
            for (int i = 0; i < person.Length; i++)
            {
                Police temp = person[i] as Police;
                if(temp!=null)
                    Console.WriteLine(temp.ToString());
            } 
            Console.WriteLine("-------------------------------------------");
            //for (int i = 0; i < person.Length; i++)
            //{
            //    Person temp = person[i] as Person;
            //    if(temp!=null)
            //       temp.printevent();
            //}
            Console.WriteLine("------------------------------------------");
            while (true)
            {
                Console.WriteLine("tap 0 To Exit");
                Console.Write("ID: ");
                string user = Console.ReadLine();
                if (user == 0 + "")
                    break;
                if (Police.LoginID(person, user) == false)
                {
                    Console.WriteLine("Erorr, officer not detected");
                    continue;
                }
                for (int i = 0; i <= 5; i++)
                {
                    if (i==5)
                    {
                        Console.WriteLine("EROR, Now you need wait 15 minute");
                        Time(ref i);
                    }
                    Console.Write("Password: ");
                    string Bdika = Console.ReadLine();
                    if (Checkuser(Bdika) == false)
                    {
                        Console.WriteLine("You must use only with nembrs");
                        continue;
                    }
                    int intuser = int.Parse(Bdika);
                    if (Police.LoginPassword(person, intuser, user) == false)
                    {
                        Console.WriteLine("Erorr, TRY Again");
                        continue;
                    }
                    if (Police.LoginPassword(person, intuser, user))
                        break;
                    
                }
                
                Console.WriteLine("Hello Officer");
                while (true)
                {
                    Console.Write("person ID: ");
                    user = Console.ReadLine();
                    if (user == 0 + "")
                        break;
                    if (CheckID(person, user) == false)
                    {
                        Console.WriteLine("Erorr, ID not detected, Try again");
                        continue;
                    }
                    ShowPerson(person, user);
                    if (CheckPast(person, user))
                    {
                        Console.WriteLine("do you want to see the criminal event? ");
                        string choice = Console.ReadLine();
                        if (choice != "yes")
                            continue;

                        Console.WriteLine(ShowEvent(person, user));
                    }

                }
            }



        }
        public static bool CheckID(Person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Person temp = arr[i] as Person;
                if (temp!=null && temp.ID == user)
                    return true;
            }
            return false;
        }


        static void ShowPerson(Person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Person temp = arr[i] as Person;
                if (temp!=null && temp.ID == user)
                    temp.ToString();
            }
        }
        public static bool CheckPast(Person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Person temp = arr[i] as Person;
                if (temp != null && temp.ID == user && temp.IsHasPast == true)
                    return true;
            }
            return false;
        }

        static string ShowEvent(Person[] arr, string user)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Person temp = arr[i] as Person;
                if (temp!=null && temp.ID == user)
                    return temp.Event;
            }
            return "has no Event";
        }

        static void AddEvent(Person[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                Person temp = arr[i] as Person;
                if (temp != null && temp.IsHasPast)
                {
                    for (int j = 0; j < rnd.Next(3); j++)
                    {
                        temp.Event += " ," + temp.events();
                    }
                }
                   
            }

        }
        static bool Checkuser(string user)
        {
            if (user == "")
                return false;
            for (int i = 0; i < user.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (user[i] + "" == j + "")
                        break;
                    if (j == 9)
                        return false;
                }
            }
            return true;
        }
        static void Time(ref int i)
        {
            string Minute = DateTime.UtcNow.Minute.ToString();
            int time = int.Parse(Minute);
            int timer = time + 1;
            while (true)
            {
                if (timer+""==DateTime.UtcNow.Minute.ToString())
                {
                    i = 0;
                    break;
                }
            }
        }
    }
}
