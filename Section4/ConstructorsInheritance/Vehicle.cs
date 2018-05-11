namespace ConstructorsInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        // public Vehicle()
        // {
        //     System.Console.WriteLine("Vehicle is being initialized");
        // }

        public Vehicle(string regNumber)
        {
            _registrationNumber = regNumber;

            System.Console.WriteLine("Vehicle is being initialized. {0}", regNumber);
        }
    }
}