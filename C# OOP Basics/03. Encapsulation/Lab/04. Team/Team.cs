using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Team
{
    private List<Person> firstTeam;
    private List<Person> reserveTeam;
    private string name;

    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return this.firstTeam; }
    }

    public IReadOnlyCollection<Person> ReserveTeam
    {
        get { return reserveTeam; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Team(string name)
    {
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
        this.name = name;
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            this.firstTeam.Add(person);
        }
        else
        {
            this.reserveTeam.Add(person);
        }
    }
}