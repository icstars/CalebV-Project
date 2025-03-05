using CSharpNameSpaceDeliverable.Occupation;
using CSharpNameSpaceDeliverable.Car;
using CSharpNameSpaceDeliverable.People;

public class Program
{
    public static void Main(string[] args)
    {
        CalebVPeople calebPerson = new CalebVPeople();
        ChristineVPeople christinePerson = new ChristineVPeople();

        CalebVCar calebCar = new CalebVCar();
        ChristineVCar christineCar = new ChristineVCar();

        CalebVOcc calebOccupation = new CalebVOcc();
        ChristineVOcc christineOccupation = new ChristineVOcc();

        Console.WriteLine("\n--- Caleb's Information ---");
        calebPerson.Info();
        calebCar.Info();
        calebOccupation.Info();

        Console.WriteLine("\n--- Christine's Information ---");
        christinePerson.Info();
        christineCar.Info();
        christineOccupation.Info();
    }
}
