using System;
namespace CreatureSimulationDemo
{
	public class Cat : Creature
	{
        public Cat(string name) : base(name)
        { }
            public override void Eat()
        {
            Console.WriteLine($"{Name}, a cat, eats delicately");

        }
    
    }
}

