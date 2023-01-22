using System;
using System.Xml.Linq;

namespace FurnitureStore
{
	public class Driver : Worker, ISwear, IMove, ICommunicationWithCustomer
	{
		public Driver(string name, int age, string vacancy, string car)
		{
            Name = name;
            Age = age;
            Vacancy = vacancy;
			Car = car;
        }

        public string Name { get; }
        public int Age { get; set; }
        public string Vacancy { get; }
        public string Car { get; set; }

        public void Swear()
        {
            Console.WriteLine("Ти куди їдеш?!");
        }

        public void Move()
        {
            Console.WriteLine($"Driver {Name} on {Car} going to you.");
        }

        public void Communicate()
        {
            Console.WriteLine($"Hi its {Name} from furniture company. Im near your house pls take your package.");
        }

	}
}

