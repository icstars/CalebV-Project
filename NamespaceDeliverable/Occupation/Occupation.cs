using System;

namespace Occupation
{
    public class CalebVOcc
    {
        public string Title = "Intern";
        public string Company = "I.C. Stars";

        public int Stripend = 300;

        public void Info()
        {
            Console.WriteLine("I am an " + Title + "at " + Company);
        }
        static void Main(string[] args)
        {
            CalebVOcc occupation = new CalebVOcc();
            occupation.Title = "Intern";
            occupation.Company = "I.C. Stars";
            occupation.Stripend = 300;
            occupation.Info();
        }
    }
    public class ChristineVOcc
    {   
        public string Title = "Teacher";
        public string Company = "Goodwill";
        public int Stripend = 1500;

        public void Info()
        {
            Console.WriteLine("I am a " + Title + "at " + Company);
        }
        static void Main(string[] args)
        {
            ChristineVOcc occupation = new ChristineVOcc();
            occupation.Title = "Teacher";
            occupation.Company = "Goodwill";
            occupation.Stripend = 1500;
            occupation.Info();
        }
    }
}
        