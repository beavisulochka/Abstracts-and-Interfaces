using System;
namespace FurnitureStore
{
	public class Program
	{
        public static void Main(String[] args)
        {
            Driver Max = new Driver("Max", 34, "driver", "Chevrolet");
            Builder Jack = new Builder("Jackl", 23, "builder", "kids furniture");
            Max.Communicate();
            Jack.Move();
        }
    }
}

