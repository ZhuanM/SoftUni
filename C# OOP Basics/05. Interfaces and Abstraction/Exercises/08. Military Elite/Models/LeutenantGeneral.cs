using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private List<Private> privates; // We will use this collection just to be able to internally change the collection without it being able to be changed from the outside (Program class); and cast it to IReadOnlyCollection later on as a "final" product

    public LeutenantGeneral(string id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName, salary)
    {
        this.privates = new List<Private>();
    }

    public IReadOnlyCollection<IPrivate> Privates
    {
        get => this.privates; 
    }

    public void AddPrivate(Private newPrivate)
    {
        this.privates.Add(newPrivate);
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .AppendLine("Privates:");

        foreach (var currentPrivate in privates)
        {
            builder.AppendLine("  " + currentPrivate);
        }

        return builder.ToString().TrimEnd();
    }
}