using System;
using System.Collections.Generic;
using System.Text;

namespace police
{
    class Person
    {
        public string ID;
        public String Firsname;
        public string Lastname;
        public bool IsHasPast;
        public string Event;
        public Person()
        {

        }
        //public void print()
        //{
        //    Console.WriteLine("full name: {0} {1}, ID:{2}, DoYouHavePast: {3}", Firsname, Lastname, ID, IsHasPast);
        //}
        public virtual string ToString()
        {
            return "full name: " + Firsname + " " + Lastname + ", " + "ID: " + ID + ", " + "DoYouHavePast: " + IsHasPast; ;
        }
        public void RandomString()
        {
            string[] firstname = { "alex", "eyal", "ariel", "eliran", "ron", "kfir", "shon", "or", "hen", "nadav", "oren", "lior", "adam", "sharon", "stav", "koren" };
            string[] lastname = { "cohen", "levi", "pereth", "fridman", "fishman", "ziyoni", "tuvia", "shtern", "rupin", "svisa", "zehavi", "shtibel", "zaguri" };

            Random rnd = new Random();
            int f = rnd.Next(firstname.Length);
            Firsname = firstname[f];
            int l = rnd.Next(lastname.Length);
            Lastname = lastname[l];
        }

        public string RandomID()
        {
            Random rnd = new Random();
            string id = "";
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    id += rnd.Next(1, 3) + "";
                }
                id += rnd.Next(9) + "";
            }
            return ID = id;
        }

        public bool RandomIfPast()
        {
            Random rnd = new Random();
            return IsHasPast = rnd.Next(0, 2) > 0;
        }

        public string events()
        {
            string[] Events = { "robbery at bank", "violence at Home", "roberry at home", "Drive without a license", "escape from police", "failur to wear a mask" };
            Random rnd = new Random();

            if (IsHasPast == true)
            {
                int E = rnd.Next(Events.Length);
                return Event = Events[E];

            }
            else
                return Event = "This person have no criminal events";
        }
        public void printevent()
        {
            Console.WriteLine("Event: {0}", Event);
        }

    }
}
