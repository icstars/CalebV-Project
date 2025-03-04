using System;

namespace People
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
        static void Main(string[] args)
        {
            CalebVPeople people = new CalebVPeople();
            
            people.gender = "Male";
            people.Name = "Caleb Vissia";
            people.isRH = true;
            people.Info();
        }
    }

    public class ChristineVPeople{
        public string Name = "Christine Vissia";
        public int age = 58;
        public bool isRH = true;
        public string gender = "Female";
    public void Info()
        {
            Console.WriteLine("My Name is " + Name + " and I am " + age);
        }
    static void Main(string[] args){
        ChristineVPeople people = new ChristineVPeople();
        people.age = 58;
        people.gender = "Female";
        people.Name = "Christine Vissia";
        people.isRH = true;
        people.Info();
    }
    }
}
