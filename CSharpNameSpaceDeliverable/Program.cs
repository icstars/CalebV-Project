/* using CSharpNameSpaceDeliverable.Occupation;
using CSharpNameSpaceDeliverable.Car;
using CSharpNameSpaceDeliverable.People;
    class ChristineInfo
    {
        public void CarInfo()
        {
            
            CSharpNameSpaceDeliverable.Car.ChristineVCar car = new CSharpNameSpaceDeliverable.Car.ChristineVCar();
            Console.WriteLine($"Car Company: {car.Company}, Model: {car.Name}, Year: {car.year}");
        }

        public void OccupationInfo()
        {
            CSharpNameSpaceDeliverable.Occupation.ChristineVOcc occupation = new CSharpNameSpaceDeliverable.Occupation.ChristineVOcc();
            Console.WriteLine($"Job: {occupation.Title}, Company: {occupation.Company}, Stripend: {occupation.Stripend}");
        }

        public void PeopleInfo()
        {
            CSharpNameSpaceDeliverable.People.ChristineVPeople person = new CSharpNameSpaceDeliverable.People.ChristineVPeople();
            Console.WriteLine($"Name: {person.Name}, Age: {person.age}, Gender: {person.gender}");
        }
    }
    class CalebInfo{
        public void CarInfo()
        {
            
            CSharpNameSpaceDeliverable.Car.CalebVCar car = new CSharpNameSpaceDeliverable.Car.CalebVCar();
            Console.WriteLine($"Car Company: {car.Company}, Model: {car.Name}, Year: {car.year}");
        }

        public void OccupationInfo()
        {
            CSharpNameSpaceDeliverable.Occupation.CalebVOcc occupation = new CSharpNameSpaceDeliverable.Occupation.CalebVOcc();
            Console.WriteLine($"Job: {occupation.Title}, Company: {occupation.Company}, Stripend: {occupation.Stripend}");
        }

        public void PeopleInfo()
        {
            CSharpNameSpaceDeliverable.People.CalebVPeople person = new CSharpNameSpaceDeliverable.People.CalebVPeople();
            Console.WriteLine($"Name: {person.Name}, Age: {person.age}, Gender: {person.gender}");
        }
    }
    public class Program
{
    public static void Main(string[] args)
    {
        CalebInfo caleb = new CalebInfo();
        ChristineInfo christine = new ChristineInfo();

        caleb.CarInfo();
        caleb.OccupationInfo();
        caleb.PeopleInfo();

        christine.CarInfo();
        christine.OccupationInfo();
        christine.PeopleInfo();
    }
} */
using System;
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
