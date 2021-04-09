
namespace Exercise01.Classes
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }



        public Car()
        {

        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        

        public int CalculateSpeed(int carSpeed, int driversSkill)
        {
            int result = carSpeed * driversSkill;
            return result;
        }
    }
}
