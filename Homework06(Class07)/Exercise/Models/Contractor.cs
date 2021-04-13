
namespace Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }

        public object Responsible { get; set; }


        public Contractor(string firstName, string lastName, double workHours, int payPerHour, object responsible) : base(firstName, lastName, Role.Other)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
          
        }
        public override double GetSalary()
        {
            
            return WorkHours * PayPerHour;
        }

        public string CurrentPosition(string department)
        {
            return department;
        }

       
    }
    
    
}
