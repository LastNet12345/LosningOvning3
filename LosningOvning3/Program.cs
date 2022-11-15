using LosningOvning3;



var personHandler = new PersonHandler();

try
{
	//var person = new Person();
	//person.Age = 10;
	//person.FirstName = "P";

	var person = personHandler.CreatePerson("Pelle", 20);
	personHandler.SetAge(person, 21);

}
catch (ArgumentException ex)
{

	Console.WriteLine(ex.Message);

}



var animalFarm = new List<Animal>();

animalFarm.Add(new Horse("Lille Skutt", 8, "Fullblod"));
animalFarm.Add(new Dog("Fido", 6, true));
animalFarm.Add(new Worm("Squirmy", 0, true));
animalFarm.Add(new Wolf("Petra", 3, 4));
animalFarm.Add(new Wolfman("Petrus", 54, 0, 42));


foreach (var animal in animalFarm)
{
	Console.WriteLine(animal.Stats());
	Console.WriteLine(animal.DoSound());
	if (animal is Dog)
	{
		var temp = animal as Dog;
		Console.WriteLine(temp.DoTrick());
		//var temp2 = (Dog)animal;
		//Console.WriteLine(temp2.DoTrick());
	}

	if (animal is IPerson)
	{
		var temp = animal as IPerson;
		Console.WriteLine(temp.Talk());
	}


	Console.WriteLine();
}

