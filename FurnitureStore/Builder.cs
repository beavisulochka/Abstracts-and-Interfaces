using System;
namespace FurnitureStore
{
	public class Builder : Worker, ISwear, IMove
	{
        public Builder(string name, int age, string vacancy, string buildertype)
        {
            Name = name;
            Age = age;
            Vacancy = vacancy;
            BuilderType = buildertype;  
        }

        public string Name { get; }
        public int Age { get; set; }
        public string Vacancy { get; set; }
		public string BuilderType { get; set; }

        public void Swear()
        {
            Console.WriteLine("Shittt");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moving to another room for building another forniture.");
        }
    }
}

