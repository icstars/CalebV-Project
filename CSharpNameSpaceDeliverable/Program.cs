
using CSharpNameSpaceDeliverable.Car;
using CSharpNameSpaceDeliverable.Occupation;
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
    class Program
    {
        public void Main(string[] args)
        {
            CalebInfo.CarInfo();
            CalebInfo.OccupationInfo();
            CalebInfo.PeopleInfo();
            ChristineInfo.CarInfo();
            ChristineInfo.OccupationInfo();
            ChristineInfo.PeopleInfo();
        }
    }