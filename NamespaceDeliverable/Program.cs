using System;
using Car;
using Occupation;
using People;
    class ChristineInfo
    {
        static void DisplayCarInfo()
        {
            
            Car.ChristineVCar car = new Car.ChristineVCar();
            Console.WriteLine($"Car Company: {car.Company}, Model: {car.Name}, Year: {car.year}");
        }

        static void DisplayOccupationInfo()
        {
            Occupation.ChristineVOcc occupation = new Occupation.ChristineVOcc();
            Console.WriteLine($"Title: {occupation.Title}, Company: {occupation.Company}, Stripend: {occupation.Stripend}");
        }

        static void DisplayPeopleInfo()
        {
            People.ChristineVPeople person = new ChristineVPeople();
            Console.WriteLine($"Name: {person.Name}, Age: {person.age}, Gender: {person.gender}");
        }
    }
    class CalebInfo{
        static void DisplayCarInfo()
        {
            
            Car.CalebVCar car = new Car.CalebVCar();
            Console.WriteLine($"Car Company: {car.Company}, Model: {car.Name}, Year: {car.year}");
        }

        static void DisplayOccupationInfo()
        {
            Occupation.CalebVOcc occupation = new CalebVOcc();
            Console.WriteLine($"Title: {occupation.Title}, Company: {occupation.Company}, Stripend: {occupation.Stripend}");
        }

        static void DisplayPeopleInfo()
        {
            People.CalebVPeople person = new CalebVPeople();
            Console.WriteLine($"Name: {person.Name}, Age: {person.age}, Gender: {person.gender}");
        }
    }