/* /* using System;

namespace CSharpNameSpaceDeliverable.Occupation
{
    class CalebVOcc
    {
        public string Title = "Intern";
        public string Company = "I.C. Stars";

        public int Stripend = 300;
        public void Info()
        {
            CalebVOcc occupation = new CalebVOcc();
            Console.WriteLine("Title: " + occupation.Title + " Company: " + occupation.Company + " Stripend: " + occupation.Stripend);
        }
        public void Main(string[] args)
        {
            CalebVOcc occupation = new CalebVOcc();
            occupation.Title = "Intern";
            occupation.Company = "I.C. Stars";
            occupation.Stripend = 300;
            occupation.Info();
        }

    }
    class ChristineVOcc
    {   
        public string Title = "Teacher";
        public string Company = "Goodwill";
        public int Stripend = 1400;

        public void Info()
        {
            ChristineVOcc occupation = new ChristineVOcc();
            Console.WriteLine("Title: " + occupation.Title + " Company: " + occupation.Company + " Stripend: " + occupation.Stripend);
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
         */
namespace CSharpNameSpaceDeliverable.Occupation
{
    class CalebVOcc
    {
        public string Title = "Intern";
        public string Company = "I.C. Stars";
        public int Stripend = 300;

        public void Info()
        {
            Console.WriteLine($"Title: {Title}, Company: {Company}, Stripend: {Stripend}");
        }
    }

    class ChristineVOcc
    {
        public string Title = "Teacher";
        public string Company = "Goodwill";
        public int Stripend = 1400;

        public void Info()
        {
            Console.WriteLine($"Title: {Title}, Company: {Company}, Stripend: {Stripend}");
        }
    }
}
