using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Room
{
    public Room(int id)
    {
        Id = id;
        Patients = new List<Patient>();
    }
    public List<Patient> Patients { get; private set; }
    public int Id { get; private set; }

    public void AddPatient(Patient patient)
    {
        if (Patients.Count >= 3)
        {
            throw new Exception();
        }

        this.Patients.Add(patient);
    }
}