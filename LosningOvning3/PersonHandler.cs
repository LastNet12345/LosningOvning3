namespace LosningOvning3
{
    public class PersonHandler
    {

        public Person CreatePerson(string firstName = "Testname", int age = 10)
        {
            var person = new Person();
            person.FirstName = firstName;
            person.Age = age;

            return person;

        }

        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }


    }
}
