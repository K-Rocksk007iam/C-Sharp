namespace InterfaceDemo
{
    public class Dog : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("veg");
        }
        public void sound() {
            Console.WriteLine("bark");
        }
    }

    public class Tiger : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("NON-veg");
        }
        public void sound()
        {
            Console.WriteLine("Roar");
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Animal");
            IAnimal dog = new Dog();
            IAnimal tiger = new Tiger();
            Console.WriteLine("Dog");
            dog.eat();
            dog.sound();
            Console.WriteLine("Tiger");
            tiger.sound();  
            tiger.eat();

        }
    }


}