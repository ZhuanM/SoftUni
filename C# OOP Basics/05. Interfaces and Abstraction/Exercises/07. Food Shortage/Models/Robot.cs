using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Robot : IIdentifiable
{
    public string Model { get; set; }

    public string Id { get; set; }

    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }
}