using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            {

                HeistCrew heistCrew1 = new HeistCrew("Potatoe lovers");

                Console.WriteLine("Plan your Heist!");

                while (run)
                    Console.Write("What is your team member's name? ");
                string teamMemberName = Console.ReadLine();
                if (teamMemberName == "")
                {
                    run = false;
                }
                else
                {

                    Console.Write("What is your team member's skill? 1-50 ");
                    var teamMemberSkill = int.Parse(Console.ReadLine());

                    Console.Write("What is your team member's courage? 0.0- 2.0");
                    var teamMemberCourage = double.Parse(Console.ReadLine());

                    TeamMember teamMember = new TeamMember(teamMemberName, teamMemberSkill, teamMemberCourage);
                    heistCrew1.addTeamMember(teamMember);

                    heistCrew1.displayHeistCrew();
                }
            }
        }
    }
}
