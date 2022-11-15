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

foreach (var animal in animalFarm)
{
	Console.WriteLine(animal.Stats());
	Console.WriteLine(animal.DoSound());
	Console.WriteLine();
}

