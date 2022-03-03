using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");

            Console.Write("What is your team member's name? ");
            string TeamMemberName = Console.ReadLine();

            Console.Write("What is your team member's skill? 1-50 ");
            var TeamMemberSkill = int.Parse(Console.ReadLine());

            Console.Write("What is your team member's courage? 0.0- 2.0");
            var TeamMemberCourage = decimal.Parse(Console.ReadLine());

            Console.Write($"Team member's information: \n Team member name: {TeamMemberName}, \n Team member skill: {TeamMemberSkill}, \n Team member courage: {TeamMemberCourage}");
        }
    }
}
