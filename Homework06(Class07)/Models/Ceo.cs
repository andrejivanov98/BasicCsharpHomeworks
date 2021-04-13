
namespace Models
{
    public class Ceo : Employee
    {
        public int SharesProperty { get; set; }
        internal double SharesPrice { get; set; }

  

    public Ceo(string firstName, string lastName, int sharesProperty, double sharesPrice) : base(firstName, lastName, Role.Other, 10000)
    {
            SharesProperty = sharesProperty;
            SharesPrice = sharesPrice;
            
    }



    public double AddSharesPrice(double num)
    {
            return SharesPrice * num;
    }

        public override double GetSalary()
        {
            return Salary + SharesProperty * SharesPrice;
        }
    }
}
