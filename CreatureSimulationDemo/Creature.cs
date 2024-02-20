using System;
namespace CreatureSimulationDemo
{
	public class Creature
	{
		private int hungerLevel = 0;
		private int thirstLevel = 0;
		public string Name { get; set; }

		public int HungerLevel { get => hungerLevel; set => hungerLevel = value; }
		public int ThirstLevel { get => thirstLevel; set => thirstLevel = value; }

		public Creature(string name)
		{
			Name = name;
		}
		
		public void Move() { }
        public virtual void Talk()
        {
			Console.WriteLine($"{Name} talks.");
        }

		public virtual void Eat()
		{
			Console.WriteLine($"This creature, {Name}, is eating.");
		}

		public void Breathe()
		{
		}
    }
}

