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
