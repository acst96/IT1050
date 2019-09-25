using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.) compute Full name 
            //2.) compute height cm (double)
            //3.) compute if you can vote (bool)


            string firstname;

            string middlename;
            string lastname;

            Console.WriteLine("fristname:");

            firstname = Console.ReadLine();

            Console.WriteLine("middlename:");

            middlename = Console.ReadLine();

            Console.WriteLine("lastname:");
            lastname = Console.ReadLine();


            string fullname = firstname + " " + middlename + " " + lastname;



            firstname = System.Console.ReadLine();

            Console.WriteLine(fullname);

            Console.ReadKey();
            //////////////////////////////////////////////////
            //////////////////////////////////////////////////

            const double cm_multiplier = 2.54;
            const double inches_per_foot = 12;
            int heightfeet;
            double heightinches;

            Console.WriteLine("Height Feet: ");
            heightfeet = int.Parse(Console.ReadLine());

            Console.WriteLine("Height Inches:");
            heightinches = int.Parse(Console.ReadLine());

            double inches = heightfeet * inches_per_foot;

            inches += heightinches;

            double heightcm = cm_multiplier = inches;

            Console.WriteLine();
            Console.WriteLine(heightcm);

            Console.WriteLine();
            Console.ReadKey();

            //////////////////////////////////
            ///
            int age;
            bool iscitizen;

            Console.Write("YourAge");
            age = int.Parse(Console.ReadLine());

            Console.Write("citizen?");
            bool iscitizen = Console.ReadLine().ToLower()startwith("y");
        }
    }
}
