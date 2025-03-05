using System;

namespace CSharpNameSpaceDeliverable.Occupation
{
    public class CalebVOcc
    {
        public string Title;
        public string Company;

        public int Stripend;
        public void Info()
        {
            CalebVOcc occupation = new CalebVOcc();
            Console.WriteLine("Title: " + Title + " Company: " + Company + " Stripend: " + Stripend);
        }
        public static void Main(string[] args)
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
        public int Stripend = 1400;

        public void Info()
        {
            ChristineVOcc occupation = new ChristineVOcc();
            Console.WriteLine("Title: " + Title + " Company: " + Company + " Stripend: " + Stripend);
        }
        public static void Main(string[] args)
        {
            ChristineVOcc occupation = new ChristineVOcc();
            occupation.Title = "Teacher";
            occupation.Company = "Goodwill";
            occupation.Stripend = 1500;
            occupation.Info();
        }
    }
}
        