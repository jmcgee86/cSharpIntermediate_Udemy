namespace ConstructorsInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            System.Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}