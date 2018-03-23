using System;
using System.Collections.Generic;
using System.Text;

public abstract class Worker
{
    private string id;
    private int workingHours;

    public Worker(string id)
    {
        this.id = id;
    }

    public void Work(int hours)
    {
        this.workingHours += hours;
    }

    //public abstract void Sleep();

    //public abstract void Recharge();
}