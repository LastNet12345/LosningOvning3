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
            return $"Species: {this.GetType().Name}, Name: {Name}, Age: {Age}, ";
        }
    }

    public class Horse : Animal, IPerson
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

        public string Talk()
        {
            return "I'm a Centaur!";
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
            return "*woff*";
        }

        public override string Stats()
        {
            return base.Stats() + $"Is good boy? {IsGoodBoy}";
        }

        public string DoTrick()
        {
            return "*does a backflip*";
        }


    }

    public class Worm : Animal
    {
        public bool IsSlimy { get; set; }
        public Worm(string name, int age, bool isSlimy) : base(name, age)
        {
            IsSlimy = isSlimy;
        }

        public override string DoSound()
        {
            return "*wriggle*";
        }

        public override string Stats()
        {
            return base.Stats() + $"Is slimy? {IsSlimy}";
        }
    }

    public class Wolf : Animal
    {
        public int NrOfPackMembers { get; set; }
        public Wolf(string name, int age, int nrOfPackMembers) : base(name, age)
        {
            NrOfPackMembers = nrOfPackMembers;
        }

        public override string DoSound()
        {
            return "*howl*";
        }

        public override string Stats()
        {
            return base.Stats() + $"Number of pack members: {NrOfPackMembers}";
        }
    }

    public class Wolfman : Wolf, IPerson
    {
        public int ShoeSize { get; set; }
        public Wolfman(string name, int age, int nrOfPackMembers, int shoeSize) : base(name, age, nrOfPackMembers)
        {
            ShoeSize = shoeSize;
        }

        public string Talk()
        {
            return "Free me from my curse!";
        }

        public override string DoSound()
        {
            return "*sligthly different howl*";
        }

        public override string Stats()
        {
            return base.Stats() + $"Shoe size: {ShoeSize}";
        }
    }


}
