namespace LosningOvning3
{
    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive number.");
                }
                age = value;
            }
        }


        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name must have at least two letters.");
                }
                firstName = value;
            }
        }


    }
}
