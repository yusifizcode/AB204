namespace Abstractions
{
    internal abstract class Animal
    {
        // public abstract string Name;
        public abstract bool Gender { get; set; }
        public int Speed { get; set; }
        public byte Age { get; set; }

        public abstract void Eat();
        public Animal(bool gender)
        {
            Gender = gender;
        }


        public virtual void MakeSound()
        {
            Console.WriteLine("animal sound");
        }
    }
}
