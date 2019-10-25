using System;

namespace Asignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            Console.WriteLine("whats your First Name?");
            p1.Firstname = Console.ReadLine();
            Console.WriteLine("whats your Last Name?");
            p1.Lastname = Console.ReadLine();
            Console.WriteLine("Whats your Age?");
            p1.Age = int.Parse(Console.ReadLine());
            p2 = new Person();
            Console.WriteLine("Whats your First Name?");
            p2.Firstname = Console.ReadLine();
            Console.WriteLine("Whats your Last Name?");
            p2.Lastname = Console.ReadLine();
             
            

        

        }


}


}
