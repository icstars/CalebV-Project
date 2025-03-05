
namespace CSharpNameSpaceDeliverable.Car
{
    public class CalebVCar
    {
        public string Name = "Focus SE";
        public int year = 2015;
        public string Company = "Ford";
        public bool isInsured = true;
        public static void Info()
        {
            CalebVCar car = new CalebVCar();
            Console.WriteLine($"Car Company: {car.Company}, Model: {car.Name}, Year: {car.year}");
        }
        public static void CarInfo(string[] args)
        {
            
            {
                CalebVCar car = new CalebVCar();
                car.Name = "Focus SE";
                car.Company = "Ford";
                car.year = 2015;
                car.isInsured = true;
            };
        }
        
    }
public class ChristineVCar
{
        public string Name = "Azera";
        public int year = 2020;
        public string Company = "Hyundai";
        public bool isInsured = true;
        public static void Info()
        {
            ChristineVCar car = new ChristineVCar();
            Console.WriteLine($"Car Company: {car.Company}, Model: {car.Name}, Year: {car.year}");
        }

        public static void CarInfo()
    
           
            {
                 ChristineVCar car = new ChristineVCar();
                car.Name = "Azera";
                car.Company = "Hyundai";
                car.year = 2020;
                car.isInsured = true;
            }
            
        }
        }
