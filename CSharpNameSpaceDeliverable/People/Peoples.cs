/* using System;

namespace CSharpNameSpaceDeliverable.People
{
    public class CalebVPeople
    {
        public string Name = "Caleb Vissia";
        public int age = 26;
        public bool isRH = true;

        public string gender = "Male";

        public void Info()
        {
            Console.WriteLine("My Name is " + Name + " and I am " + age);
        }
        public static void Main(string[] args)
        {
            CalebVPeople people = new CalebVPeople();
            people.gender = "Male";
            people.age = 26;
            people.Name = "Caleb Vissia";
            people.isRH = true;
            people.Info();
        }
    }

    public class ChristineVPeople{
        public string Name = "Christine Vissia";
        public int age = 57;
        public bool isRH = true;
        public string gender = "Female";
    public void Info()
        {
            ChristineVPeople people = new ChristineVPeople();
            Console.WriteLine("My Name is " + people.Name + " and I am " + people.age);
        }
    public static void Main(string[] args){
        ChristineVPeople people = new ChristineVPeople();
        people.age = 58;
        people.gender = "Female";
        people.Name = "Christine Vissia";
        people.isRH = true;
        people.Info();
    }
    }
}
 */
using System;

namespace CSharpNameSpaceDeliverable.People
{
    public class CalebVPeople
    {
        public string Name = "Caleb Vissia";
        public int Age = 26;
        public bool IsRH = true;
        public string Gender = "Male";

        public void Info()
        {
            Console.WriteLine($"My Name is {Name} and I am {Age} years old.");
        }
    }

    public class ChristineVPeople
    {
        public string Name = "Christine Vissia";
        public int Age = 57;
        public bool IsRH = true;
        public string Gender = "Female";

        public void Info()
        {
            Console.WriteLine($"My Name is {Name} and I am {Age} years old.");
        }
    }
}
