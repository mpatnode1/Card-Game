using System;
namespace CreatureSimulationDemo
{
	public class World
	{
		List<Creature> Creatures = new List<Creature>();

		public void Start()
		{
			Creatures.Add(new Dragon("Joe"));
			Creatures.Add(new Cat("Sam"));
			Creatures.Add(new Penguin("Pam"));
			ShowAllCreatures();
		}

		private void ShowAllCreatures()
		{
			foreach (Creature creature in Creatures)
			{
				Console.WriteLine(creature.Name);
				creature.Talk();
				creature.Eat();
			}
		}
	}
}

