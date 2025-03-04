using System;

namespace Car
{
    public class CalebVCar
    {
        public string Name = "Focus SE";
        public int year = 2015;
        public string Company = "Ford";

        public bool isInsured = true;

        public void CarInfo()
        {
        CalebVCar car = new CalebVCar();
        car.Name = "Focus SE";
        car.Company = "Ford";
        car.year = 2015;
        car.isInsured = true;
        car.CarInfo();
        }
    }

public class ChristineVCar
{

        public string Name = "Focus SE";
        public int year = 2015;
        public string Company = "Ford";

        public bool isInsured = true;

        public void CarInfo()
        {
        ChristineVCar car = new ChristineVCar();
        car.Name = "Azera";
        car.Company = "Hyundai";
        car.year = 2020;
        car.isInsured = true;
        car.CarInfo();
        }
        static void Main(string[] args){
        ChristineVCar car = new ChristineVCar();
        car.Name = "Azera";
        car.Company = "Hyundai";
        car.year = 2020;
        car.isInsured = true;
        car.CarInfo();
        }
    }
}