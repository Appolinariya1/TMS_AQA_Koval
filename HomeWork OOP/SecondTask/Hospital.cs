using HomeWork_OOP.SecondTask.Doctors;

namespace HomeWork_OOP.SecondTask;

public class Hospital
{
   private Dentist _dentist = new Dentist();
   private Surgeon _surgeon = new Surgeon();
   private Therapist _therapist = new Therapist();

   public void StartDay(Patient[] patients)
   {
      foreach (var patient in patients)
      {
         AssignDoctor(patient);
         patient.AssignedDoctor.Treat(patient.Name);
      }
   }

   public void AssignDoctor(Patient patient)
   {
      switch (patient.TreatmentPlan.TreatmentPlanCode)
      {
         case 1:
            patient.AssignedDoctor = _surgeon;
            break;
         case 2:
            patient.AssignedDoctor = _dentist;
            break;
         default:
            patient.AssignedDoctor = _therapist;
            break;
      }
   }
}