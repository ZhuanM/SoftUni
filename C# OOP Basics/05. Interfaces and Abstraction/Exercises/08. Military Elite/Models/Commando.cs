using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Commando : SpecialisedSoldier, ICommando
{
    private List<Mission> missions;

    public Commando(string id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.missions = new List<Mission>();
    }

    public IReadOnlyCollection<IMission> Missions
    {
        get => this.missions;
    }

    public void AddMission(Mission mission)
    {
        this.missions.Add(mission);
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .AppendLine("Missions:");

        this.missions
            .ForEach(m => builder.AppendLine(m.ToString()));

        return builder.ToString().TrimEnd();
    }
}