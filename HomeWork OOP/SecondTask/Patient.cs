namespace HomeWork_OOP.SecondTask;

public class Patient
{
    public TreatmentPlan TreatmentPlan { get; set; }
    public Doctor AssignedDoctor { get; set; }
    public string Name { get; set; }
    
    public Patient(string name)
    {
        Name = name;
    }
    
    public Patient(string name, TreatmentPlan treatmentPlan)
    {
        TreatmentPlan = treatmentPlan;
        Name = name;
    }
}