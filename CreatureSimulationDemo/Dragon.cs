using System;
namespace CreatureSimulationDemo
{
	public class Dragon : Creature
	{
		public Dragon(string name) : base(name)
		{
		}

		public override void Talk()
		{
			Console.WriteLine("With a burst of flames and a thunderous sound.");
			base.Talk();
		}

        public override void Eat()
        {
            Console.WriteLine($"{Name}, a dragon, is a vegan.");

        }

    }
}

