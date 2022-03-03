
namespace Heist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int Skill { get; set; }
        public double Courage { get; set; }

        public TeamMember(string name, int skill, double courage)
        {
            Name = name;
            Skill = skill;
            Courage = courage;
        }
    }
}
