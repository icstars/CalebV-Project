namespace CSharpNameSpaceDeliverable.Car
{
    public class CalebVCar
    {
        public string Name = "Focus SE";
        public int Year = 2015;
        public string Company = "Ford";
        public bool IsInsured = true;

        public void Info()
        {
            Console.WriteLine($"Car Company: {Company}, Model: {Name}, Year: {Year}, Insured: {IsInsured}");
        }
    }

    public class ChristineVCar
    {
        public string Name = "Azera";
        public int Year = 2020;
        public string Company = "Hyundai";
        public bool IsInsured = true;

        public void Info()
        {
            Console.WriteLine($"Car Company: {Company}, Model: {Name}, Year: {Year}, Insured: {IsInsured}");
        }
    }
}
