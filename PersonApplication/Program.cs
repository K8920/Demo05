using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a few Person objects
            Person person1 = new Person {Firstname = "Martti", Lastname = "Maukas", SocialSecurityNumber = "060593-2032"};
            Person person2 = new Person {Firstname = "Jokke", Lastname = "Jokelainen", SocialSecurityNumber = "020599-129S"};
            Person person3 = new Person {Firstname = "Jyrki", Lastname = "Kivi", SocialSecurityNumber = "060474-230H"};

            //create a Persons object
            Persons myFriends = new Persons();

            // add person objects to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person from Persons collection
            Person person4 = myFriends.GetPerson(0);
            if (person4 !=null)
            {
                Console.WriteLine(person4);
            }
            else
            {
                Console.WriteLine("Person not found in that index!");
            }

            // print collection
            myFriends.PrintCollection();

            // find person
            string sotu = "0404040-238";
            Console.WriteLine("Find sotu: " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5);
            }
            else
            {
                Console.WriteLine("Cant find person with that sotu...");
            }
        }
    }
}
