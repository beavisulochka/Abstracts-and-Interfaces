using System;
using System.Xml.Linq;

namespace FurnitureStore
{
    public class Cashier : Worker, ICommunicationWithCustomer, ISwear
    {
        public Cashier(string name, int age, string vacancy, int cashRegisterNumber)
	{
            Name = name;
            Age = age;
            Vacancy = vacancy;
            CashRregisterNumber = cashRegisterNumber;
        }

        public string Name { get; }
        public int Age { get; set; }
        public string Vacancy { get; set; }
	public int CashRregisterNumber { get; set; }

        public void Communicate()
        {
            Console.WriteLine("Hi, you need bag?");
        }

        public void Swear()
        {
            Console.WriteLine("Faster!");
        }
    }
}

