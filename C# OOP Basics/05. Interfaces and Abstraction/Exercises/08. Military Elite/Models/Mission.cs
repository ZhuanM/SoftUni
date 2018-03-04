using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Mission : IMission
{
    private MissionState state;   

    public string State
    {
        get => this.state.ToString();

        private set
        {
            MissionState state;
            if (!Enum.TryParse(value, out state))
            {
                throw new ArgumentException();
            }

            this.state = state;
        }
    }

    public string CodeName { get; private set; }

    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    public void CompleteMission()
    {
        this.state = MissionState.Finished;
    }

    public override string ToString()
    {
        return $"  Code Name: {CodeName} State: {State}";
    }
}