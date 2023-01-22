using System;
using System.Xml.Linq;

namespace FurnitureStore
{
	public class DepartmentEmployee : Worker, ICommunicationWithCustomer, IMove
    {
		public DepartmentEmployee(string name, int age, string vacancy, string workingSection)
		{
            Name = name;
            Age = age;
            Vacancy = vacancy;
            WorkingSection = workingSection;
        }

        public string Name { get; }
        public int Age { get; set; }
        public string Vacancy { get; set; }
        public string WorkingSection { get; set; }

        public void Communicate()
        {
            Console.WriteLine($"Hi, my name is {Name}. How I can help you?");
        }

        public void Move()
        {
            Console.WriteLine($"Wait, worker {Name} going for help to you");
        }
    }
}

