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


