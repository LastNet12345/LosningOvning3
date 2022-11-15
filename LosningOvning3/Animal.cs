namespace LosningOvning3
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, ";
        }
    }

    public class Horse : Animal
    {
        public string Breed { get; set; }
        public Horse(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        public override string DoSound()
        {
            return "*niegh*";
        }

        public override string Stats()
        {
            return base.Stats() + $"Breed: {Breed}";
        }
    }

    public class Dog : Animal
    {
        public bool IsGoodBoy { get; set; }
        public Dog(string name, int age, bool isGoodBoy) : base(name, age)
        {
            IsGoodBoy = isGoodBoy;
        }

        public override string DoSound()
        {
            return "*woff";
        }

        public override string Stats()
        {
            return base.Stats() + $"Is good boy: {IsGoodBoy}";
        }
    }
}
