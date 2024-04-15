namespace Abstractions
{
    internal class Dog : Animal
    {
        public string Sort { get; set; }
        public override bool Gender { get; set; }

        public override void Eat()
        {
            Console.WriteLine("dogun yemek yemeyi");
        }

        public Dog(bool gender) : base(gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("hav hav");
        }


    }
}
