using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Spy : Soldier, ISpy
{
    public Spy(string id, string firstName, string lastName, int code)
        : base(id, firstName, lastName)
    {
        this.Code = code;
    }

    public int Code { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .Append($"Code Number: {Code}");

        return builder.ToString();
    }
}